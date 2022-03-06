using CoreLeaveManagement.Web.Contracts;
using CoreLeaveManagement.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLeaveManagement.Web.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _context;
        public LeaveHistoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(LeaveHistory entity)
        {
            _context.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _context.LeaveHistories.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            var leaveHistories = _context.LeaveHistories.ToList();
            return leaveHistories;
        }

        public LeaveHistory FindById(int id)
        {
            var leaveHistory = _context.LeaveHistories.Find(id);
            return leaveHistory;
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

        public bool Update(LeaveHistory entity)
        {
            _context.LeaveHistories.Update(entity);
            return Save();
        }
    }
}
