using College_Project.Infra.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace College_Project.Infra.Base
{
    public class ResponseBase
    {
        public EResponseStatus IsSuccess { get; set; } = EResponseStatus.Failed; //1: Success, 2: Exception/Failed, 3: Partial
        public string Message { get; set; } = "Failed!";
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

    }
}
