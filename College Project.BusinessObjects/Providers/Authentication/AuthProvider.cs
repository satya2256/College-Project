using College_Project.BusinessObjects.Mappers;
using College_Project.Data.Repositories.Authentication;
using College_Project.Entities;
using College_Project.Infra.Base;
using College_Project.Infra.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace College_Project.BusinessObjects.Providers.Authentication
{
    public class AuthProvider:ProviderBase,IAuthprovider
    {
        public async Task<ClientResponse<UserStudent>> RegisterStudent(UserStudent userStudent)
        {
            var clientResponse = new ClientResponse<UserStudent>();
            AuthRepository authRepository = new AuthRepository();
            try
            {
                if(userStudent.Password == userStudent.ConfirmPassword)
                {
                    var inUserModel = AuthMapper.RegisterStudentModel(userStudent);
                    if (inUserModel != null)
                    {
                        var outUserModel = await authRepository.RegisterStudent(inUserModel);
                        if (outUserModel != null)
                        {
                           clientResponse.Result = AuthMapper.RegisterStudent(outUserModel);
                           
                        }
                        if (clientResponse.Result != null)
                        {
                            //Success 
                            clientResponse = UpdateClientResponse(clientResponse, EResponseStatus.Success);
                        }
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
