using marathon_session1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marathon_session1.Helper
{
    class DB
    {
        private static Context instanse;

        public DB()
        {

        }

        public static Context Instanse
        {
            get
            {
                instanse = instanse ?? new Context();
                
                return instanse;
            }

        }


    }
}
