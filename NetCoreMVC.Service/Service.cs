using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreMVC.Data;

namespace NetCoreMVC.Service
{
    public class Service
    {
        public Service()
        {
        }
        public string datacall()
        {
            var obj = new ApplicationDBContext();
            return obj.datacall();
        }
    }

}
