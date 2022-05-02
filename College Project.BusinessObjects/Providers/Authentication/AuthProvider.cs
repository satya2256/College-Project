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
    public class AuthProvider : ProviderBase, IAuthprovider
    {
        public ClientResponse<UserStudent> RegisterStudent(UserStudent userStudent)
        {
            var clientResponse = new ClientResponse<UserStudent>();
            AuthRepository authRepository = new AuthRepository();
            try
            {
                //Register Student
                var searchUser = authRepository.SearchStudent(userStudent.Email);
                if(searchUser == null)
                {
                    if (userStudent.Id == 0 && (userStudent.Password == userStudent.ConfirmPassword))
                    {
                        var inUserModel = AuthMapper.RegisterStudentModel(userStudent);
                        if (inUserModel != null)
                        {
                            var outUserModel = authRepository.RegisterStudent(inUserModel);
                            if (outUserModel != null)
                            {
                                clientResponse.Result = AuthMapper.RegisterStudent(outUserModel);

                            }
                            if (clientResponse.Result != null)
                            {
                                //Success 
                                clientResponse = UpdateClientResponse(clientResponse, EResponseStatus.Success);
                            }
                            else
                            {
                                clientResponse.Message = "Registering failed...try again!!!!";
                            }
                        }
                    }
                    else
                    {
                        clientResponse = UpdateClientResponse(clientResponse, EResponseStatus.Success);
                        clientResponse.Message = "Password and confirm Password should be same";

                    }
                }
                else
                {
                    clientResponse = UpdateClientResponse(clientResponse, EResponseStatus.Success);
                    clientResponse.Message = "User already exists...Please try with different email";
                }
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return clientResponse;
        }
        public ClientResponse<UserStudent> GetStudentDetails(string rollNumber)
        {
            var clientResponse = new ClientResponse<UserStudent>();
            AuthRepository authRepository = new AuthRepository();

            var inUserModel = authRepository.GetStudentDetails(rollNumber);
            if (inUserModel != null)
            {
                var outUserModel = AuthMapper.RegisterStudent(inUserModel);
                if (outUserModel != null)
                {
                    clientResponse.Result = outUserModel;

                }
                if (clientResponse.Result != null)
                {
                    //Success 
                    clientResponse = UpdateClientResponse(clientResponse, EResponseStatus.Success);
                }

            }
            else
            {
                clientResponse = UpdateClientResponse(clientResponse, EResponseStatus.Success);
                clientResponse.Message = "Student Details not found for given roll number";
            }
            return clientResponse;



        }
        public ClientResponse<UserStudent> GetStudentDetails(string rollNumber, string password)
        {
            var clientResponse = new ClientResponse<UserStudent>();
            AuthRepository authRepository = new AuthRepository();

            var inUserModel = authRepository.GetStudentDetails(rollNumber, password);
            if (inUserModel != null)
            {
                var outUserModel = AuthMapper.RegisterStudent(inUserModel);
                if (outUserModel != null)
                {
                    clientResponse.Result = outUserModel;

                }
                if (clientResponse.Result != null)
                {
                    //Success 
                    clientResponse = UpdateClientResponse(clientResponse, EResponseStatus.Success);
                }

            }
            else
            {
                clientResponse = UpdateClientResponse(clientResponse, EResponseStatus.Success);
                clientResponse.Message = "Student Details not found";
            }
            return clientResponse;



        }
        public ClientResponse<bool> DeleteStudent(string rollNumber, string password)
        {
            var clientResponse = new ClientResponse<bool>();
            AuthRepository authRepository = new AuthRepository();

            var inUserModel = authRepository.GetStudentDetails(rollNumber,password);
            if(inUserModel != null)
            {
                inUserModel.IsActive = false;
                var outUserModel = authRepository.DeleteStudent(inUserModel);
                if (outUserModel != null && outUserModel.IsActive == false)
                {
                    clientResponse = UpdateClientResponse(clientResponse, EResponseStatus.Success);
                    clientResponse.Result = true;
                    clientResponse.Message = "Student Deleted Successfully..!";

                }
                else
                {
                    clientResponse.Message = "Student not Deleted try again..!";
                }
            }
            else
            {
                clientResponse = UpdateClientResponse(clientResponse, EResponseStatus.Success);
                clientResponse.Result = true;
                clientResponse.Message = "Student not found...!";
            }
           
            
            return clientResponse;


        }
    
    }
}
