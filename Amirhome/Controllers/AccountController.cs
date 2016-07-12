﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Mvc;
using System.IO;
using Amirhome.Models;

namespace Amirhome.Controllers
{
    public class AccountController : Controller
    {
        UserManager _userManager = new UserManager();
        public ActionResult RegisterView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterView(UserAccouunt model)
        {
            try
            {
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase img = Request.Files[0];
                    byte[] data = null;
                    long numBytes = img.ContentLength;
                    BinaryReader bin_reader = new BinaryReader(img.InputStream);
                    data = bin_reader.ReadBytes((int)numBytes);
                    model.ProfileImage = data;
                }
                model.Approved = true;
                bool res = _userManager.createNewUser(model);
                if (res)
                    ViewBag.Message = "حساب کاربری با موفقیت ثبت گردید";
                else
                    ModelState.AddModelError("", "کاربر با این آدرس ایمیل قبلاً ثبت شده است");
            }
            catch
            {
                ModelState.AddModelError("", "خطا در ثبت حساب کاربری");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            try
            {
                int id = _userManager.authenticateUser(email, password);
                if (id < 0)
                {
                    return Json("ایمیل یا کلمه عبور اشتباه است");
                }
                else
                {
                    Session["UserID"] = id;
                    return Json("success");
                }
            }
            catch
            {
                return Json("خطا در برقراری ارتباط با سرور");
            }
        }
        
    }
}