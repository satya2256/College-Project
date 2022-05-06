using College_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace College_Project.Data.Repositories.Authentication
{
    public interface IAuthRepository
    {
        UserStudent RegisterStudent(UserStudent userStudent);
        UserStudent SearchStudent(string email);
        UserStudent GetStudentDetails(string rollNumber);
        UserStudent GetStudentDetails(string rollNumber, string password);
        UserStudent GetDeletedStudentDetails(string rollNumber, string password);
        UserProfessor RegisterProfessor(UserProfessor userProfessor);
        UserProfessor SearchProfessor(string email);

    }
}
