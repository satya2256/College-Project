using College_Project.Entities;
using College_Project.Infra.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace College_Project.BusinessObjects.Providers.Authentication
{
    public interface IAuthprovider
    {
        Task<ClientResponse<UserStudent>> RegisterStudent(UserStudent userStudent);
    }
}
