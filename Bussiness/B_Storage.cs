using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class B_Storage
    {

        public List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public void CreateStorage(StorageEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oInputOutput);
                db.SaveChanges();
            }
        }

        public void UpdateStorage(StorageEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oInputOutput);
                db.SaveChanges();
            }
        }

    }
}
