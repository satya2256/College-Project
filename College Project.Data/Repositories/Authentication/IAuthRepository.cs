using College_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace College_Project.Data.Repositories.Authentication
{
    public interface IAuthRepository
    {
        Task<UserStudent> RegisterStudent(UserStudent userStudent);
        Task<UserStudent> SearchStudent(string email);

    }
}
