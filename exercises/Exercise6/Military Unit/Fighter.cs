using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Fighter:Aircraft
     {
          private float Speed;

          public void setSpeed(float spe) { this.Speed = spe; }
          public float getSpeed() { return this.Speed; }
          public Fighter()
          {
               //Console.WriteLine("Fighter Class Constructor called");
          }
          public override void DeployWeapon()
          {
               base.DeployWeapon();
          }
          public override string ToString()
          {
               return base.ToString() + "\n Speed: " + Speed + " km/h ";
          }
     }
}
