using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class NonUniform:Personnel
     {
          private int PersonsCapacity;

          public void setPersonsCapacity(int ten) { this.PersonsCapacity = ten; }
          public int getPersonsCapacity() { return this.PersonsCapacity; }
          public NonUniform()
          {
               //Console.WriteLine("NonUniform Class Constructor called");
          }
          public override void Duty()
          {
               base.Duty();
          }
          public override string ToString()
          {
               return base.ToString() + "\n PersonsCapacity: " + PersonsCapacity;
          }
     }
}
