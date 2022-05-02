using College_Project.Data.Context;
using College_Project.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace College_Project.Data.Repositories.Data_Repository
{
    public class DataRepository:IDataRepository
    {
        //public void Dispose()
        //{
        //    this.Dispose();
        //}

        public List<UserType> GetUserTypes()
        {
            
            using (CollegeContext collegeContext = new CollegeContext())
            {
                return collegeContext.UserType.Where(x => x.IsActive == true).ToList();
            }
           
            
        }
    }
}
