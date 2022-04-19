using College_Project.BusinessObjects.Mappers;
using College_Project.Data.Repositories.Data_Repository;
using College_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace College_Project.BusinessObjects.Providers.Data
{
    public class DataProvider:IDataProvider
    {
        public IEnumerable<UserType> GetUserTypes()
        {
            try
            {
                using (DataRepository dataRepository = new DataRepository())
                {
                    var userTypesModel = dataRepository.GetUserTypes();
                    var userTypes = DataMapper.GetUserTypes(userTypesModel);
                    return userTypes;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            
        }
    }
}
