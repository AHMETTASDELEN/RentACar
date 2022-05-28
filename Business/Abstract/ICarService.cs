using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<CarDetailDto> GetCarDetails();
    }
}

//decimaller int olabilir