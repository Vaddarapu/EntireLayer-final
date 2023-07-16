using DataAccessLayer.Entities;
using DataAccessLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EmployeRepository : IEmployeRepository
    {
        private readonly EmployeDbContext employeDbContext;
        public EmployeRepository(EmployeDbContext _employeDbContext)
        {
            employeDbContext = _employeDbContext;
        }
        public void AddEmploye(Employe employe) 
        {
            employeDbContext.Add(employe);
            employeDbContext.SaveChanges();
        }



        public List<Employe> GetAllEmploye()
        {
           return employeDbContext.Employes.ToList();

        }


        public Employe GetEmployeById(int id)
        {
            return employeDbContext.Employes.FirstOrDefault(x => x.EmpId == id);
        }

     

        public bool updateEmploye(Employe employe)
        {
            var IsUpdated = false;
            var emp = employeDbContext.Employes.FirstOrDefault(x => x.EmpId == employe.EmpId);
            if (emp != null)
            {
                emp.EmpSal = employe.EmpSal;
                emp.EmpName = employe.EmpName;
                emp.EmpCity = employe.EmpCity;
                emp.EmpId = employe.EmpId;
                emp.CreateDate = DateTime.Now;
                emp.EmpAddress = employe.EmpAddress;
                IsUpdated = true;
                employeDbContext.SaveChanges();
            }
            return IsUpdated;
        }
     

        public void deleteEmploye(int id)
        {
            Employe employe = employeDbContext.Employes.FirstOrDefault(x => x.EmpId == id);
            employeDbContext.Remove(employe);
            employeDbContext.SaveChanges();
        }
    }
}
