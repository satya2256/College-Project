﻿using College_Project.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace College_Project.Entities
{
    public class UserProfessor:EntityBase
    {
    
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Branch Branch { get; set; } = new Branch();

        //test for jira demo session
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}
