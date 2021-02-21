using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
     public class Weapon
     {
          private int    WeaponID;
          private string WeaponName;
          private float  WeaponWeight;
          private string WeaponEffectiveness;
          private string WeaponUsage;
          private float  WeaponRange;

          public Weapon()
          {
               //Console.WriteLine("Weapon Class Constructor called");
          }

          public Weapon(int WeaponID,string WeaponName,float WeaponWeight,string WeaponEffectiveness,string WeaponUsage,float WeaponRange)
          {
               //Console.WriteLine("Weapon Class Constructor called");

               this.WeaponID = WeaponID;
               this.WeaponName = WeaponName;
               this.WeaponWeight = WeaponWeight;
               this.WeaponEffectiveness = WeaponEffectiveness;
               this.WeaponUsage = WeaponUsage;
               this.WeaponRange = WeaponRange;

          }
          public void setWeaponID(int id) { this.WeaponID = id; }
          public int getPersonID() { return this.WeaponID; }
          public void setWeaponName(string name) { this.WeaponName = name; }
          public string getWeaponName() { return this.WeaponName; }
          public void setWeaponWeight(float wei) { this.WeaponWeight = wei; }
          public float getWeaponWeight() { return this.WeaponWeight; }
          public void setWeaponEffectiveness(string eff) { this.WeaponEffectiveness = eff; }
          public string getWeaponEffectiveness() { return this.WeaponEffectiveness; }
          public void setWeaponUsage(string use) { this.WeaponUsage = use; }
          public string getWeaponUsage() { return this.WeaponUsage; }
          public void setWeaponRange(float ran) { this.WeaponRange = ran; }
          public float getWeaponRange() { return this.WeaponRange; }          
          public virtual void Usage() { Console.WriteLine(" Usage "); }
          public virtual void Range() { Console.WriteLine(" Range "); }
          public virtual void Effective() { Console.WriteLine(" Effective "); }
          public override string ToString()
          {
               return /*base.ToString() +*/ " WeaponID: " + WeaponID + "\n WeaponName: " + WeaponName + "\n WeaponWeight: " + WeaponWeight + " kg " + "\n WeaponUsage: " + WeaponUsage + "\n WeaponRange: " + WeaponRange + " km " + "\n WeaponEffectiveness: " + WeaponEffectiveness;
          }
     }
}
