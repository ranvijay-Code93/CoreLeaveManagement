using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoreLeaveManagement.Web.Contracts;
using CoreLeaveManagement.Web.Data;
using CoreLeaveManagement.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreLeaveManagement.Web.Controllers
{
    public class LeaveTypeController : Controller
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _autoMapper;

        public LeaveTypeController(ILeaveTypeRepository leaveTypeRepository, IMapper autoMapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _autoMapper = autoMapper;
        }

        // GET: LeaveTypeController
        public ActionResult Index()
        {
            var leaveTypes = _leaveTypeRepository.FindAll().ToList();
            var model = _autoMapper.Map<List<LeaveType>, List<LeaveTypeViewModel>>(leaveTypes);
            return View(model);
        }

        // GET: LeaveTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LeaveTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LeaveTypeViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var leaveType = _autoMapper.Map<LeaveType>(model);
                bool isLeaveCreated = _leaveTypeRepository.Create(leaveType);

                if (!isLeaveCreated)
                {
                    ModelState.AddModelError("", "Something went wrong...");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeaveTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LeaveTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeaveTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeaveTypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
