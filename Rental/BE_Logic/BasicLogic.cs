using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rental.Dal;

namespace Rental.BE_Logic
{
    public class BaseLogic : IDisposable //n-tiers 3 layers 

    {
        private CarsDal _db = new CarsDal();

        protected CarsDal DB
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
