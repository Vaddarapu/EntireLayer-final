using DataAccessLayer.Entities;
using DataAccessLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace ServiceLayerorBL.IServices
{
    public interface  IEmployeeService
    {
        void AddEmploye(EmployeViewModel employe);
        List<EmployeViewModel> GetAllEmploye();
        EmployeViewModel GetEmployeById(int id);
        bool updateEmploye(EmployeViewModel employeViewModel);
        void DeleteEmploye(int id);

    }
}
