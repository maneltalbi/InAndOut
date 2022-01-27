﻿using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExpenseController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            // IEnumerable<Expense> objList = _db.Expenses;
            // return View(objList);
            return View();
        }
        //get create
        public IActionResult Create()
        {
            return View();
        }
        //post create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense obj)
        {
            _db.Expenses.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}