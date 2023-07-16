using DataAccessLayer.Entities;
using DataAccessLayer.IRepositories;
using ServiceLayerorBL.IServices;
using ViewModel;

namespace ServiceLayerorBL.Services
{
    public class EmployeService : IEmployeeService
    {
  
        private readonly IEmployeRepository   employeRepository ;
        public EmployeService(IEmployeRepository _employeRepository)
        {
            employeRepository = _employeRepository;
        }       
        public void AddEmploye(EmployeViewModel employeViewModel)
        {
            Employe employe = new Employe();
            employe.EmpAddress = employeViewModel.EmpAddress;
            employe.EmpCity = employeViewModel.EmpCity;
            employe.EmpName = employeViewModel.EmpName;
           employeRepository.AddEmploye(employe);
        }



        public List<EmployeViewModel> GetAllEmploye()
        {
           List<Employe>  emplist =  employeRepository.GetAllEmploye();
            List<EmployeViewModel> empvmlist = new List<EmployeViewModel>();
            foreach (Employe emp in emplist) 
            { 
              EmployeViewModel empvm = new EmployeViewModel();
                empvm.EmpAddress = emp.EmpAddress;
                empvm.EmpCity = emp.EmpCity;    
                empvm.EmpName = emp.EmpName;    
                empvm.EmpId = emp.EmpId;
                empvm.EmpSal = emp.EmpSal;
                empvmlist.Add(empvm);
            }
            return empvmlist;  
        }

     

        public EmployeViewModel GetEmployeById(int id)
        {
            Employe employe   =  employeRepository.GetEmployeById(id);
            EmployeViewModel empVm= new EmployeViewModel();
            empVm.EmpAddress = employe.EmpAddress;
            empVm.EmpCity = employe.EmpCity;
            empVm.EmpName = employe.EmpName;
            empVm.EmpId = employe.EmpId;
            empVm.EmpSal = employe.EmpSal;
            return empVm;
        }

        public bool updateEmploye(EmployeViewModel employeViewModel)
        {
            Employe employe = new Employe();
            employe.EmpSal = employeViewModel.EmpSal;
            employe.EmpCity = employeViewModel.EmpCity; 
            employe.EmpAddress = employeViewModel.EmpAddress;   
            employe.EmpName = employeViewModel.EmpName;     
            return employeRepository.updateEmploye(employe);

        }
        public void DeleteEmploye(int id)
        {
            employeRepository.deleteEmploye(id);
        }
    }
}
   
   
       
        

        
    

