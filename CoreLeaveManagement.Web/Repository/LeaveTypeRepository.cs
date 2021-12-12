using CoreLeaveManagement.Web.Contracts;
using CoreLeaveManagement.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLeaveManagement.Web.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _context;
        public LeaveTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(LeaveType entity)
        {
            _context.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _context.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            var leaveTypes = _context.LeaveTypes.ToList();
            return leaveTypes;
        }

        public LeaveType FindById(int id)
        {

            var leaveType = _context.LeaveTypes.Find(id);
            return leaveType;
        }

        public ICollection<LeaveType> GetAllEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var rowsAffected = _context.SaveChanges();
            return rowsAffected > 0;
        }

        public bool Update(LeaveType entity)
        {
            _context.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
