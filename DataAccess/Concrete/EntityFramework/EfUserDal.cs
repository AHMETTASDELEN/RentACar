using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from u in context.Users
                             join c in context.Customers on u.UserId equals c.UserId
                             select new UserDetailDto
                             {
                                 UserId=u.UserId,
                                 FirstName=u.FirstName,
                                 LastName=u.LastName,
                                 CompanyName=c.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
