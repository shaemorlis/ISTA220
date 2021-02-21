using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class LightWeapons:Weapon
     {
          private bool ManPower;
          private float BallWeight;

          public LightWeapons()
          {
               //Console.WriteLine("LightWeapons Class Constructor called");
          }

          public LightWeapons(int WeaponID, string WeaponName, float WeaponWeight, string WeaponEffectiveness, string WeaponUsage, float WeaponRange, bool ManPower, float BallWeight) : base( WeaponID,  WeaponName,  WeaponWeight,  WeaponEffectiveness,  WeaponUsage, WeaponRange)
          {
               this.ManPower = ManPower;
               this.BallWeight = BallWeight;
          }
          public void setManPower(bool auto) { this.ManPower = auto; }
          public bool getManPower() { return this.ManPower; }
          public void setBallWeight(float bul) { this.BallWeight = bul; }
          public float getBallWeight() { return this.BallWeight; }
          
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
               return base.ToString() + "\n ManPower: " + ManPower + "\n BallWeight: " + BallWeight + " kg ";
          }
     }
}
