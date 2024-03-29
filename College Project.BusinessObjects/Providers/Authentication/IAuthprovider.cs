﻿using College_Project.Entities;
using College_Project.Infra.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace College_Project.BusinessObjects.Providers.Authentication
{
    public interface IAuthprovider
    {
        ClientResponse<UserStudent> RegisterStudent(UserStudent userStudent);
        ClientResponse<UserStudent> GetStudentDetails(string rollNumber);
        ClientResponse<UserStudent> GetStudentDetails(string rollNumber, string password);
        ClientResponse<List<UserStudent>> GetStudentsDetailsByBranchName(string branchName);
        ClientResponse<bool> DeleteStudent(string rollNumber, string password);
        ClientResponse<UserProfessor> RegisterProfessor(UserProfessor userProfessor);
        ClientResponse<UserProfessor> GetProfessorDetails(string email);
        ClientResponse<UserStudent> UpdateStudent(UserStudent userStudent);
        DataTable ConvertCSVtoDataTable(string strFilePath);
    }
}
