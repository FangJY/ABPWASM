using ABPWASM.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPWASM.Modeling
{

    [ApiExplorerSettings(GroupName = "V3")]
    public class MfgOrder : Modeling<MfgOrderDto>
    {
        public ServiceResult<object> Copy(MfgOrderDto obj)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<object> Delete(MfgOrderDto obj)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<object> New(MfgOrderDto obj)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<object> Update(MfgOrderDto obj)
        {
            throw new NotImplementedException();
        }
    }
}
