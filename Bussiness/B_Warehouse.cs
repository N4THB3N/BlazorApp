using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class B_Warehouse
    {

        public List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void CreateWarehouse(WarehouseEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oCategory);
                db.SaveChanges();
            }
        }

        public void UpdateWarehouse(WarehouseEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(oCategory);
                db.SaveChanges();
            }
        }

    }
}
