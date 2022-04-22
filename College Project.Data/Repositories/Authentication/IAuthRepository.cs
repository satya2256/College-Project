using College_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace College_Project.Data.Repositories.Authentication
{
    public interface IAuthRepository
    {
        public UserStudent RegisterStudent(UserStudent userStudent);
    }
}
