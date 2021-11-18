using ABPWASM.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace ABPWASM
{
    public interface  Modeling<T>: IApplicationService
    {
        ServiceResult<object> New(T obj);
        ServiceResult<object> Update(T obj);
        ServiceResult<object> Delete(T obj);
        ServiceResult<object> Copy(T obj);
    }
}
