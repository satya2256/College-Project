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
        readonly CollegeContext _collegeContext;
        public AuthRepository(CollegeContext collegeContext)
        {
            _collegeContext = collegeContext;
        }

        public UserStudent RegisterStudent(UserStudent userStudent)
        {
            try
            {
                var register = _collegeContext.Add(userStudent);
                int count = _collegeContext.SaveChanges();
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
        public UserStudent UpdateStudent(UserStudent userStudent)
        {
            try
            {
                var register = _collegeContext.Update(userStudent);
                int count = _collegeContext.SaveChanges();
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
                var search = _collegeContext.UserStudent.Where(x => x.Email == email && x.IsActive == true)
                    .Include(br => br.Branch).FirstOrDefault();
                return search;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public UserStudent GetStudentDetails(string rollNumber)
        {
            try
            {
                var search = _collegeContext.UserStudent.Where(x => x.RollNumber.ToLower() == rollNumber.ToLower() && x.IsActive == true)
                    .Include(br => br.Branch).FirstOrDefault();
                return search;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public UserStudent GetStudentDetails(string rollNumber, string password)
        {
            try
            {
                var search = _collegeContext.UserStudent.Where(x => x.RollNumber.ToLower() == rollNumber.ToLower() && x.Password == password && x.IsActive == true)
                    .Include(br => br.Branch).FirstOrDefault();
                return search;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public UserStudent GetDeletedStudentDetails(string rollNumber, string password)
        {
            try
            {
                var search = _collegeContext.UserStudent.Where(x => x.RollNumber.ToLower() == rollNumber.ToLower() && x.Password == password && x.IsActive == false)
                    .Include(br => br.Branch).FirstOrDefault();
                return search;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<UserStudent> GetStudentsDetailsByBranchName(string branchName)
        {
            try
            {
                //CollegeContext collegeContext = new CollegeContext();
                var search = _collegeContext.UserStudent.Where(x => x.Branch.BranchName.ToLower() == branchName.ToLower())
                    .Include(br => br.Branch).ToList();
                return search;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public UserStudent DeleteStudent(UserStudent userStudent)
        {
            try
            {

                var update = _collegeContext.UserStudent.Update(userStudent);
                int count = _collegeContext.SaveChanges();
                if (count > 0)
                {
                    return GetDeletedStudentDetails(userStudent.RollNumber, userStudent.Password);

                }
            }

            catch (Exception ex)
            {

                throw ex;
            }
            return null;

        }
        public UserProfessor RegisterProfessor(UserProfessor userProfessor)
        {
            try
            {
                //CollegeContext collegeContext = new CollegeContext();
                _collegeContext.Add(userProfessor);
                int count = _collegeContext.SaveChanges();
                if (count > 0)
                {
                    return SearchProfessor(userProfessor.Email);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return null;
            
        }
        public UserProfessor SearchProfessor(string email)
        {
            try
            {
                //CollegeContext collegeContext = new CollegeContext();
                var search = _collegeContext.UserProfessor.Where(x => x.Email == email && x.IsActive == true)
                    .Include(br=>br.Branch).FirstOrDefault();
                return search;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
         
        }










    }
}
