using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{     
    public class Ship:Vehicle
     {
          private float Depth;
          public void setDepth(float dep) { this.Depth = dep; }
          public float getDepth() { return this.Depth; }
          public Ship() 
          {
              // Console.WriteLine("Ship Class Constructor called");
          }          
          public override void ChangeHeading()
          {
               base.ChangeHeading();
          }
          public override string ToString()
          {
               return base.ToString() + "\n Depth: " + Depth + " m ";
          }
     }
}
