using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crudMVCwebApp.Models
{
    public class Employee
    {
        
        public Guid Id {get;set;}= Guid.NewGuid();
        public string Name {get;set;}=String.Empty;
        public string Email {get;set;}=string.Empty;
        public DateTime DateOfBirth {get;set;}
    }
}