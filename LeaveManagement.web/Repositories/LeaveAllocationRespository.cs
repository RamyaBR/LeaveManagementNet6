using AutoMapper;
using LeaveManagement.web.Constant;
using LeaveManagement.web.Contracts;
using LeaveManagement.web.Data;
using LeaveManagement.web.Models;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.web.Repositories
{
    public class LeaveAllocationRespository : GenericRepository<LeaveAllocation>, ILeaveAllocationRespository
    {
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public LeaveAllocationRespository(ApplicationDbContext context,
            UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper) : base(context)
        {
            _userManager = userManager;
            _leaveTypeRepository = leaveTypeRepository;
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AlocationExists(string employeeId, int leavetypeId, int period)
        {
            return await _context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId
                                                                 && q.LeaveTypeId == leavetypeId
                                                                 && q.Period == period);
        }

        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int employeeId)
        {
            var allocation = await _context.LeaveAllocations.Include(q => q.LeaveType)
          .FirstOrDefaultAsync(q=>q.Id == employeeId);

            if(allocation == null)
            {
                return null;
            }
    
            var employee = await _userManager.FindByIdAsync(allocation.EmployeeId);

            var model = _mapper.Map<LeaveAllocationEditVM>(allocation);
            model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(allocation.EmployeeId));

            return model;
        }
    

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await _context.LeaveAllocations
          .Include(q => q.LeaveType)
          .Where(q => q.EmployeeId == employeeId)
          .ToListAsync();

            var employee = await _userManager.FindByIdAsync(employeeId);

            var employeeAllocationModel = _mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.LeaveAllocations = _mapper.Map<List<LeaveAllocationVM>>(allocations);

            return employeeAllocationModel;
        }


        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await _leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();

            foreach(var employee in employees)
            {
                if (await AlocationExists(employee.Id, leaveTypeId, period))
                  {
                    continue;
                  }
                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                }); 
            }
            await AddRangeAsync(allocations);
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOFDays;
            await UpdateAsync(leaveAllocation);
            return true;
        }
    }
}
