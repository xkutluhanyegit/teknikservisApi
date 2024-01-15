using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

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
            return new SuccessDataResult<List<DbOrder>>(result,"Success");
        }
    }
}