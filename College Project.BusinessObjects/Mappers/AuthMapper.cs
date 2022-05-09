using Models=College_Project.Data.Models;
using College_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace College_Project.BusinessObjects.Mappers
{
    public  class AuthMapper
    {
        public static Models.UserStudent RegisterStudentModel(UserStudent userStudent)
        {
            if (userStudent != null)
            {
               
                    Models.UserStudent _userStudent = new Models.UserStudent();

                    _userStudent.FirstName = userStudent?.FirstName;
                    _userStudent.LastName = userStudent?.LastName;
                    _userStudent.RollNumber = userStudent?.RollNumber;
                    _userStudent.Email = userStudent?.Email;
                    _userStudent.BranchId = Convert.ToInt32(userStudent?.Branch.Id);
                    _userStudent.Password = userStudent?.Password;

                    return _userStudent;
            }
                 
            return null;
        }
        public static UserStudent RegisterStudent(Models.UserStudent userStudent)
        {
            if(userStudent !=null)
            {
                UserStudent _userStudent = new UserStudent();

                _userStudent.Id = Convert.ToInt32(userStudent?.Id);
                _userStudent.FirstName = userStudent?.FirstName;
                _userStudent.LastName = userStudent?.LastName;
                _userStudent.RollNumber = userStudent?.RollNumber;
                _userStudent.Email = userStudent?.Email;
                _userStudent.Branch.Id = Convert.ToInt32(userStudent?.BranchId);
                _userStudent.Branch.BranchName = userStudent.Branch?.BranchName;
                //_userStudent.Password = userStudent?.Password;

                return _userStudent;

            }
            return null;
        }
        public static List<UserStudent> GetStudentsDetailsByBranchName(List<Models.UserStudent> userStudents)
        {
            List<UserStudent> _userStudents = new List<UserStudent>();
            foreach (var userStudent in userStudents)
            {
                _userStudents.Add(RegisterStudent(userStudent));
            }
            return _userStudents;

        }
        public static Models.UserProfessor RegisterProfessorModel(UserProfessor userProfessor)
        {
            Models.UserProfessor _userProfessor = new Models.UserProfessor();

            _userProfessor.FirstName = userProfessor.FirstName;
            _userProfessor.LastName = userProfessor.LastName;
            _userProfessor.Email = userProfessor.Email;
            _userProfessor.Password = userProfessor.Password;
            _userProfessor.EmployeeNumber = userProfessor.EmployeeNumber;
            _userProfessor.BranchId = userProfessor.Branch.Id;

            return _userProfessor;
        }
        


        
        public static UserProfessor RegisterProfessor(Models.UserProfessor userProfessor)
        {
            UserProfessor _userProfessor = new UserProfessor();

            _userProfessor.FirstName = userProfessor.FirstName;
            _userProfessor.LastName = userProfessor.LastName;
            _userProfessor.Email = userProfessor.Email;
            //_userProfessor.Password = userProfessor.Password;
            _userProfessor.EmployeeNumber = userProfessor.EmployeeNumber;
            _userProfessor.Branch.Id = userProfessor.BranchId;
            _userProfessor.Branch.BranchName = userProfessor.Branch.BranchName;

            return _userProfessor;
        }

    }
}
