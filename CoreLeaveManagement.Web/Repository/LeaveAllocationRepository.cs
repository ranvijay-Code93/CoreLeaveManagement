using CoreLeaveManagement.Web.Contracts;
using CoreLeaveManagement.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLeaveManagement.Web.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _context;
        public LeaveAllocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(LeaveAllocation entity)
        {
            _context.LeaveAllocationes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _context.LeaveAllocationes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            var leaveAllocationes = _context.LeaveAllocationes.ToList();
            return leaveAllocationes;
        }

        public LeaveAllocation FindById(int id)
        {

            var leaveAllocation = _context.LeaveAllocationes.Find(id);
            return leaveAllocation;
        }

        public bool IsExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var rowsAffected = _context.SaveChanges();
            return rowsAffected > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _context.LeaveAllocationes.Update(entity);
            return Save();
        }
    }
}
