using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
namespace Business.Concrete
{
    public class DbOrderManager:IDbOrderService
    {
        IDbOrderDAL _dbOrderDAL;
        public DbOrderManager(IDbOrderDAL dbOrderDAL)
        {
            _dbOrderDAL = dbOrderDAL;
        }

        public IDataResult<List<DbOrder>> GetAll()
        {
            var result = _dbOrderDAL.GetAll();
            return new SuccessDataResult<List<DbOrder>>(result,Messages.ListingSuccess);
        }

        public IDataResult<List<OrdersDTO>> OrdersDTOGetAll()
        {
            
            var result = _dbOrderDAL.GetOrdersDTOs();
            return new SuccessDataResult<List<OrdersDTO>>(result,Messages.ListingSuccess);
        }
    }
}