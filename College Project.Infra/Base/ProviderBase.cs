using College_Project.Infra.Enums;
using College_Project.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace College_Project.Infra.Base
{
    public  abstract class ProviderBase:IProviderBase
    {
        protected ClientResponse<T> UpdateClientResponse<T>(ClientResponse<T> clientResponse, EResponseStatus eResponseStatus)
        {
            clientResponse.IsSuccess = eResponseStatus;
            clientResponse.Message = eResponseStatus == EResponseStatus.Failed ? "Failed!" : "Success!";
            return clientResponse;
        }

    }
}
