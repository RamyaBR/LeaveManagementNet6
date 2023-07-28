using LeaveManagement.web.Data;
using LeaveManagement.web.Models;
using LeaveManagement.Web.Models;

namespace LeaveManagement.web.Contracts
{
    public interface ILeaveAllocationRespository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AlocationExists(string employeeId, int leavetypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int employeeId);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
    }
}
