using DataAccess.DTO;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IDelegationItemRepository
    {
        void SaveItem(DelegationItem item);

        List<DelegationItem> GetAll();

        List<BaseDelegationData> GetBaseData();
    }
}
