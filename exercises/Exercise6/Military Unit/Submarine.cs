using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Submarine:Ship
     {
          private string Type;

          public void setType(string spe) { this.Type = spe; }
          public string getType() { return this.Type; }
          public Submarine()
          {
               //Console.WriteLine("Submarine Class Constructor called");
          }
          public void ChangeDepth() { }
          public override void DeployWeapon()
          {
               base.DeployWeapon();
          }
          public override string ToString()
          {
               return base.ToString() + "\n Type: " + Type;
          }
     }
}
