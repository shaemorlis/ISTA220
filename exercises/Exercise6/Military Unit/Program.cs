using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{         

    public class Program
     {
          static void Main(string[] args)
          {               
               UnitManager unitObj = new UnitManager();
               unitObj.Manage();
               Console.ReadLine();
          }
     }
}
