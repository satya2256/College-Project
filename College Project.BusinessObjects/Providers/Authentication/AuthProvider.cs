using College_Project.BusinessObjects.Mappers;
using College_Project.Data.Repositories.Authentication;
using College_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace College_Project.BusinessObjects.Providers.Authentication
{
    public class AuthProvider:IAuthprovider
    {
        public UserStudent RegisterStudent(UserStudent userStudent)
        {
            AuthRepository authRepository = new AuthRepository();
            try
            {
                var inUserModel = AuthMapper.RegisterStudentModel(userStudent);
                if (inUserModel != null)
                {
                    var outUserModel = authRepository.RegisterStudent(inUserModel);
                    if (outUserModel != null)
                    {
                        var registeredStudent = AuthMapper.RegisterStudent(outUserModel);
                        return registeredStudent;
                    }
                }
              
                else
                {
                    //
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return null;           
        }

    }
}
