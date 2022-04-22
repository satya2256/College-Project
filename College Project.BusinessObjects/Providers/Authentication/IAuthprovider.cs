using College_Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace College_Project.BusinessObjects.Providers.Authentication
{
    public interface IAuthprovider
    {
        UserStudent RegisterStudent(UserStudent userStudent);
    }
}
