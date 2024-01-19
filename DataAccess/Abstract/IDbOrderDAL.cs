using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;
using Entities.Dto;

namespace DataAccess.Abstract
{
    public interface IDbOrderDAL:IEntityRepository<DbOrder>
    {
        List<OrdersDTO> GetOrdersDTOs();
    }
}