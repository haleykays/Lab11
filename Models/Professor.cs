using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab11.Models
{
    public class Professor
    {
        public int ID {get; set;}

        public string FirstName {get; set;}
        public string LastName {get; set;}
        
    }
}