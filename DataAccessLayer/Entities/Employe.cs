using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Employe
    {
        [Key]
        public int EmpId { get; set; }
        public String EmpName { get; set; }
        public String EmpAddress { get; set; }
        public String? EmpCity { get; set; }
        [Column("decimal(10,2)")]
        public decimal EmpSal { get; set; }
        public DateTime CreateDate { get; set; }
        public int ModifiedBy { get; set; }
        public int CreatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
