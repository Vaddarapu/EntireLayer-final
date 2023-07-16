using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayerorBL.IServices;
using ServiceLayerorBL.Services;

namespace ViewModel;

public class EmployeController : Controller
{

    private readonly IEmployeeService employeeService;

    public EmployeController(IEmployeeService _employeeService)
    {
        employeeService = _employeeService;
    }

    public IActionResult Index()
    {
      List<EmployeViewModel>  employeViewModels=  employeeService.GetAllEmploye();   

        return View( employeViewModels);
    }
    [HttpGet]
    public IActionResult CreateEmploye()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateEmploye(EmployeViewModel employeViewModel)
    {
        employeeService.AddEmploye(employeViewModel);
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult EditEmploye(int Id)
    {
        var employeViewModel=employeeService.GetEmployeById(Id);
     return View(employeViewModel);
    }
    [HttpPost]
    public IActionResult updateEmploye(EmployeViewModel employeViewModel)
    {
        var isupdated = employeeService.updateEmploye(employeViewModel);
        if (isupdated)
        {
            return RedirectToAction("Index");
        }
        return  View ("EditEmploye",employeViewModel);
     }
    [HttpGet]
    public IActionResult DeleteEmploye(int Id)
    {
        employeeService.DeleteEmploye(Id);
        return RedirectToAction("Index");
    }

}

