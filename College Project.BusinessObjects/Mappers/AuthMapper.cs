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
                

                _userStudent.FirstName = userStudent?.FirstName;
                _userStudent.LastName = userStudent?.LastName;
                _userStudent.RollNumber = userStudent?.RollNumber;
                _userStudent.Email = userStudent?.Email;
                _userStudent.Branch.Id = Convert.ToInt32(userStudent?.BranchId);
                _userStudent.Branch.BranchName = userStudent.Branch?.BranchName;
                _userStudent.Password = userStudent?.Password;

                return _userStudent;

            }
            return null;
        }

    }
}
