﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace LoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("signup")]
        [HttpPost]
        public IActionResult SignUp(User newUser)
        {
            if(ModelState.IsValid) 
            {
                // System.Console.WriteLine("This is the new user coming in");
                // System.Console.WriteLine(newUser.Fname);
                // System.Console.WriteLine(newUser.Lname);
                // System.Console.WriteLine(newUser.Email);
                // System.Console.WriteLine(newUser.Password);
                // System.Console.WriteLine(newUser.ConfirmPassword);
                if(dbContext.Users.Any(u => u.Email == newUser.Email)) 
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                } 
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();
                    var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == newUser.Email);
                    HttpContext.Session.SetInt32("UserLoggedIn",userInDb.UserId);
                    return RedirectToAction("Success");
                }
            }
            else 
            {
                return View("Index");
            }
        }

        [Route("login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(LoginUser loginAttempt)
        {
            if(ModelState.IsValid)
            {
                // System.Console.WriteLine("This is the user loggin in");
                // System.Console.WriteLine(loginAttempt.Email);
                // System.Console.WriteLine(loginAttempt.Password);
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == loginAttempt.Email);
                if (userInDb == null) 
                {
                    ModelState.AddModelError("Email", "Invalid Email");
                    return View("Login");
                }

                var hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(loginAttempt, userInDb.Password, loginAttempt.Password);

                if(result == 0) 
                {
                    ModelState.AddModelError("Password", "Invalid Password");
                    return View("Login");
                }
                else 
                {
                    HttpContext.Session.SetInt32("UserLoggedIn",userInDb.UserId);
                    return RedirectToAction("Success");
                }
                
            }
            else 
            {
                return View("Login");
            }
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [Route("account/{uid}")]
        [HttpGet]
        public IActionResult Account(int uid)
        {
            User userInAccount = dbContext.Users
                .Include(user=> user.TransactionsMade)
                .FirstOrDefault(user => user.UserId == uid);
            UserTransaction aUserTransaction = new UserTransaction();
            aUserTransaction.User = userInAccount;
            return View(aUserTransaction);
            // return View();
        }

        [Route("accountinteraction")]
        [HttpPost]
        public IActionResult AccountInteraction(Transaction newTransaction)
        {
            User userInAccount = dbContext.Users
                .Include(user=> user.TransactionsMade)
                .FirstOrDefault(user => user.UserId == HttpContext.Session.GetInt32("UserLoggedIn"));
            float count = 0;
            foreach (var i in userInAccount.TransactionsMade) 
            {
                count += i.Amount;
            }

            System.Console.WriteLine("hey sam here are some tests");
            System.Console.WriteLine("here is your account at the moment");
            System.Console.WriteLine(count);
            System.Console.WriteLine("here is the ammount they want");
            System.Console.WriteLine(newTransaction.Amount);
            if(newTransaction.Amount > 0) 
            {
                newTransaction.CreatorUserId = (int)(HttpContext.Session.GetInt32("UserLoggedIn"));
                dbContext.Add(newTransaction);
                dbContext.SaveChanges();
                return RedirectToAction("Account", new {uid = HttpContext.Session.GetInt32("UserLoggedIn")});
            }
            else if (count - newTransaction.Amount < 0) 
            {
                newTransaction.CreatorUserId = (int)(HttpContext.Session.GetInt32("UserLoggedIn"));
                dbContext.Add(newTransaction);
                dbContext.SaveChanges();
                return RedirectToAction("Account", new {uid = HttpContext.Session.GetInt32("UserLoggedIn")});
            }
            else 
            {
                System.Console.WriteLine("failed transaction submission");
                UserTransaction aUserTransaction = new UserTransaction();
                aUserTransaction.User = userInAccount;
                return View("Account",aUserTransaction);
            }

        }

        [Route("success")]
        [HttpGet]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("UserLoggedIn") != null)
            {
                return RedirectToAction("Account", new {uid = HttpContext.Session.GetInt32("UserLoggedIn")});
            } 
            else 
            {
                return RedirectToAction("Index");
            }
            
        }


    }
}
