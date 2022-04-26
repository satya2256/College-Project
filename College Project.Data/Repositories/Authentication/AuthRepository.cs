using College_Project.Data.Context;
using College_Project.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Project.Data.Repositories.Authentication
{
    public class AuthRepository : IAuthRepository
    {
        CollegeContext collegeContext = new CollegeContext();

        public async Task<UserStudent> RegisterStudent(UserStudent userStudent)
        {
            try
            {
                var register =  collegeContext.Add(userStudent);
                int count = collegeContext.SaveChanges();
                if (count > 0)
                {
                    return await SearchStudent(userStudent.Email);
                }
                return null;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            
        }
        public async Task<UserStudent> SearchStudent(string email)
        {
            try
            {
                var search = await collegeContext.UserStudent.FirstOrDefaultAsync(x => x.Email == email);
                return search;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }










    }
}
