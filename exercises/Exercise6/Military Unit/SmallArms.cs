using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class SmallArms:Weapon
     {
          private bool Automatic;
          private int Bullets;

          public void setAutomatic(bool auto) { this.Automatic = auto; }
          public bool getAutomatic() { return this.Automatic; }
          public void setBullets(int bul) { this.Bullets = bul; }
          public int getBullets() { return this.Bullets; }
          public SmallArms()
          {
               //Console.WriteLine("SmallArms Class Constructor called");
          }
          public override void Usage()
          {
               base.Usage();
          }
          public override void Range()
          {
               base.Range();
          }
          public override void Effective()
          {
               base.Effective();
          }
          public override string ToString()
          {
               return base.ToString() + "\n Automatic: " + Automatic + "\n No of Bullets: " + Bullets;
          }
     }
}
