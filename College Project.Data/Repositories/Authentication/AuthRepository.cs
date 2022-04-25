using College_Project.Data.Context;
using College_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace College_Project.Data.Repositories.Authentication
{
    public class AuthRepository : IAuthRepository
    {
        CollegeContext collegeContext = new CollegeContext();

        public UserStudent RegisterStudent(UserStudent userStudent)
        {
            try
            {
                var register = collegeContext.Add(userStudent);
                int count = collegeContext.SaveChanges();
                if (count > 0)
                {
                    return SearchStudent(userStudent.Email);
                }
                return null;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            
        }
        public UserStudent SearchStudent(string email)
        {
            try
            {
                var search = collegeContext.UserStudent.Where(x => x.Email == email)?.FirstOrDefault();
                return search;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }










    }
}
