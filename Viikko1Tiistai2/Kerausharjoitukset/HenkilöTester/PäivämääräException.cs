using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenkilöTester
{
    class PäivämääräException: Exception
    {
        public PäivämääräException(string message): base (message)
        {
        }
    }
}
