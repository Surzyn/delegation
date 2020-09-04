using DataAccess.DTO;
using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class DelegationItemRepository : IDelegationItemRepository
    {
        public List<DelegationItem> GetAll()
        {
            using (var dbContext = new DelegationContext())
            {
                return dbContext.DelegationItems.ToList();
            }
        }

        public List<BaseDelegationData> GetBaseData()
        {
            using (var dbContext = new DelegationContext())
            {
                return dbContext.DelegationItems.ToList().Select(item =>
                 {
                    return new BaseDelegationData()
                     {
                         FirstName = item.FirstName,
                         LastName = item.LastName,
                         Id = item.Id,
                         From = item.Date,
                         To = item.ReturningData
                     };
                 }).ToList();
            }
        }

        public void SaveItem(DelegationItem item)
        {
            using (var dbContext = new DelegationContext())
            {
                dbContext.DelegationItems.Add(item);
                dbContext.SaveChanges();
            }
        }
    }
}
