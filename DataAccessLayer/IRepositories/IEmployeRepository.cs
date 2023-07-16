using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepositories
{
    public  interface IEmployeRepository
    {
        void AddEmploye(Employe employe);
        List<Employe> GetAllEmploye();
        Employe GetEmployeById(int id);
      bool updateEmploye( Employe employe);
        
        void deleteEmploye(int id);
    }
}
