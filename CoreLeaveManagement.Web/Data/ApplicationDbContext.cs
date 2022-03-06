using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CoreLeaveManagement.Web.Models;

namespace CoreLeaveManagement.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocationes { get; set; }
        public DbSet<LeaveHistory> LeaveHistories { get; set; }
        public DbSet<CoreLeaveManagement.Web.Models.LeaveTypeViewModel> LeaveTypeViewModel { get; set; }
    }
}
