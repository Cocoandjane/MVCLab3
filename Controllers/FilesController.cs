using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System.IO;


namespace MVCLab3.Controllers
{
    public class FilesController : Controller
    {
        public IActionResult Index()
        {
            string[] files = Directory.GetFiles("TextFiles");
            ViewBag.myFiles = files;

            foreach (var item in files)
            {
                string path = item;
                string fileName = Path.GetFileName(path);
                ViewData[item] = fileName;
                ViewBag.fileName = fileName;
            }
            return View();
        }
        public IActionResult Content(int id )
        {
            string[] files = Directory.GetFiles("TextFiles");
            ViewBag.myFiles = files;
                foreach (var item in files)
            {
                string path = item;
                string fileName = Path.GetFileName(path);
                //need to read file froom a path insilde of the project,
                // not from a file
                string text =System.IO.File.ReadAllText(item);  
                ViewData[item] = text;
            }
            return View(new string[] {});

            // void showContentByFileName(string fileName)

        }
    }
}