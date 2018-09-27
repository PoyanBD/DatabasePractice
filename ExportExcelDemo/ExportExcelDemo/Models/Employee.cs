using System;
using System.ComponentModel.DataAnnotations;
namespace ExportExcelDemo.Models
{
    public class Employee
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public int DepartmentId
        {
            get;
            set;
        }
    }
}