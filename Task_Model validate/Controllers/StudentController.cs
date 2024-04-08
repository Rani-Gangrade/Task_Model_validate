using Microsoft.AspNetCore.Mvc;
using Task_Model_validate.Models;

namespace Task_Model_validate.Controllers
{
    public class StudentController : Controller
    {
        private readonly StdDBcontext context;

        public StudentController(StdDBcontext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult ReadDta() 
        {
            var result = context.StdModels.ToList();
            return Json(result);
        }
        [HttpPost]
        public IActionResult CreateList(StdModel model)
        {

           if (ModelState.IsValid)
            {
                context.StdModels.Add(model);
                context.SaveChanges();
            }

            return Json(model);
        }
        [HttpPost]
        public IActionResult UpdateList(StdModel model)
        {
            if (ModelState.IsValid)
            {
                context.StdModels.Update(model);
                context.SaveChanges();
            }
                return Json(model);
        }

        [HttpPost]
        public IActionResult DeleteList(int Id)
        {
           var data= context.StdModels.Find(Id);
            if (data != null)
            {
                context.StdModels.Remove(data);
                context.SaveChanges();
            }
            
            return Json(Id);
        }
    }
}
