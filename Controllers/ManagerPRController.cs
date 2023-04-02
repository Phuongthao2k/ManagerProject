using Dapper;
using ManagementPurchasing.Data;
using ManagementPurchasing.Models;
using ManagementPurchasing.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding;
using System.Diagnostics;

namespace ManagerPurchase.Controllers
{
    public class ManagerPRController : Controller
    {
        // GET: ManagerPR
        private readonly IPRService _prService;

        public ManagerPRController(IPRService prService)
        {
            _prService = prService;
        }

        [HttpGet]
        public async Task<ActionResult> ManagerPR()
        {
            var prs = await _prService.GetPRs();
            return View(prs);
        }

        [HttpPost]
        public async Task<ActionResult> ManagerPR(string prCode, DateTime createdAt, string status)
        {
            var prs = await _prService.GetPRs();
            var newPrs = prs.Where(e => e.Id.Contains(prCode) 
                && e.CreatedAt == createdAt && e.status.Equals(status));
            return View(newPrs);
        }

        [HttpGet]
        public async Task<ActionResult> AddPR()
        {
            var prs = await _prService.GetPRs();
            return View(prs);
        }       
    }
}