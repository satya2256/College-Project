using College_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace College_Project.Data.Repositories.Data_Repository
{
    public interface IDataRepository
    {
        List<UserType> GetUserTypes();
    }
}
