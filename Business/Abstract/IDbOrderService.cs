using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Result;
using Entities.Concrete;
using Entities.Dto;

namespace Business.Abstract
{
    public interface IDbOrderService
    {
        IDataResult<List<DbOrder>> GetAll();
        IDataResult<List<OrdersDTO>> OrdersDTOGetAll();
    }
}