using AutoMapper;
using LeaveManagement.web.Constant;
using LeaveManagement.web.Contracts;
using LeaveManagement.web.Data;
using LeaveManagement.web.Models;
using LeaveManagement.web.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> _userManager;
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRespository _leaveAllocationRepository;
        public EmployeesController(UserManager<Employee> userManager,
            IMapper mapper,
            ILeaveAllocationRespository leaveAllocationRespository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRespository;
        }

        // GET: EmployeesController
        public async Task<ActionResult> Index()
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
            var model = _mapper.Map<IList<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: EmployeesController/ViewAllocation/5
        public async Task<ActionResult> ViewAllocation(string id)
        {
            var model = await _leaveAllocationRepository.GetEmployeeAllocations(id);
            return View(model);
        }

        // GET: EmployeesController/EditAllocation/5
        public async  Task<ActionResult> EditAllocation(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _leaveAllocationRepository.GetEmployeeAllocation(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                if(ModelState.IsValid) {

                    if (await _leaveAllocationRepository.UpdateEmployeeAllocation(model))
                    {
                        return RedirectToAction(nameof(ViewAllocation), new { id = model.EmployeeId });
                    }
                }
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "An error has occured.Please try again later.");
              
            }
            model.Employee = _mapper.Map<EmployeeListVM>(_userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = _mapper.Map<LeaveTypeVM>(_leaveAllocationRepository.GetAsync(model.LeaveTypeId));
            return View(model);
        }
    }
}
