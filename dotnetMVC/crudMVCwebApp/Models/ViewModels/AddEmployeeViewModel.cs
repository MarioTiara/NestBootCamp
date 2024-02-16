using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudMVCwebApp.Models.ViewModels
{
    public class AddEmployeeViewModel
    {
        public string Name {get;set;}=String.Empty;
        public string Email {get;set;}=string.Empty;
        public DateTime DateOfBirth {get;set;}
    }
}