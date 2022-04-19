using College_Project.Entities;
using Models=College_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace College_Project.BusinessObjects.Mappers
{
    public class DataMapper
    {
        public static UserType GetUserType(Models.UserType userTypeModel)
        {
            if (userTypeModel != null)
            {
                UserType userType = new UserType();
                userType.Id = userTypeModel.Id;
                userType.UserTypeName = userTypeModel.UserTypeName;

                return userType;
            }
            return null;
        }

        public static List<UserType> GetUserTypes(List<Models.UserType> userTypeModels)
        {
            if (userTypeModels != null && userTypeModels.Count > 0)
            {
                List<UserType> userTypes = new List<UserType>();
                foreach (var userTypeModel in userTypeModels)
                {
                    userTypes.Add(GetUserType(userTypeModel));
                }
                return userTypes;

            }
            return null;
        }




        
    }
}
