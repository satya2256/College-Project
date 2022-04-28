using System;
using System.Collections.Generic;
using System.Text;

namespace College_Project.Infra.Base
{
    public class ClientResponse<T>:ResponseBase
    {
        public T Result { get; set; }

    }
}
