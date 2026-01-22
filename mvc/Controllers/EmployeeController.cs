using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc.Models;
using mvc.ViewModel;

namespace mvc.Controllers
{
    public class EmployeeController: Controller
    {
        ITIContext context = new ITIContext();
        public IActionResult Index()
        {
            List<Employee> employeesList = context.Employees.Include(e => e.Department).ToList();
            return View("Index", employeesList);
        }

        public IActionResult Edit(int id)
        {
            Employee empModel = context.Employees.FirstOrDefault(e => e.Id == id);

            List<Department> DepartmentList = context.Departments.ToList();

            EmpWithDeptListViewModel EmpViewModel = new EmpWithDeptListViewModel();

            EmpViewModel.Id = empModel.Id;
            EmpViewModel.Name = empModel.Name;
            EmpViewModel.Salary = empModel.Salary;
            EmpViewModel.JobTitle = empModel.JobTitle;
            EmpViewModel.ImageURL = empModel.ImageURL;
            EmpViewModel.Address = empModel.Address;
            EmpViewModel.DepartmentID = empModel.DepartmentID;
            EmpViewModel.DeptList = DepartmentList;


            return View(EmpViewModel);
        }


        [HttpPost]
        public IActionResult SaveEdit(Employee emp, int id)
        {
            if (emp.Name != null)
            {
                Employee Emp = context.Employees.FirstOrDefault(e => e.Id == id);
                Emp.Name = emp.Name;
                Emp.Salary = emp.Salary;
                Emp.JobTitle = emp.JobTitle;
                Emp.ImageURL = emp.ImageURL;
                Emp.Address = emp.Address;
                Emp.DepartmentID = emp.DepartmentID;

                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("Edit", emp);
        }

        public IActionResult DetailsVM(int id)
        {
            Employee empModel = context.Employees.Include(e => e.Department).FirstOrDefault(e => e.Id == id);
            List<string> branches = new List<string>();
            branches.Add("Cairo");
            branches.Add("Alex");
            branches.Add("Aswan");

            EmpDeptColorTempMsgBrchViewModel EmpVM = new EmpDeptColorTempMsgBrchViewModel();
            EmpVM.EmpName = empModel.Name;
            EmpVM.DeptName = empModel.Department.Name;
            EmpVM.Branches = branches;
            EmpVM.Temp = 40;
            EmpVM.Msg = "Hello from MVC";
            EmpVM.Color = "Red";

            return View("DetailsVM", EmpVM);
        }
    }
}
