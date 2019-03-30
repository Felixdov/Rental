using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_BE
{
    public class BaseLogic :IDisposable //n-tiers 3 layers 

    {
        private RentCarEntities _db = new RentCarEntities();

        protected RentCarEntities DB
        {
            get
            {
                return _db;
            }
        }

        public void Dispose()
        {
            _db.Dispose(); // close connection to db
        }

    }
}
