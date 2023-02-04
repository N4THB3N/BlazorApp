using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class B_InputOutput
    {

        public List<InputOutputEntity> InOutList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInOut(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInputOutput);
                db.SaveChanges();
            }
        }

        public void UpdateInOutas(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInputOutput);
                db.SaveChanges();
            }
        }

    }
}
