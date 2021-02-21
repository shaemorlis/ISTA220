using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Uniform:Personnel
     {
          private int Tenure;

          public void setTenure(int ten) { this.Tenure = ten; }
          public int getTenure() { return this.Tenure; }
          public Uniform() 
          {
               //Console.WriteLine("Uniform Class Constructor called");
          }
          public override void Duty()
          {
               base.Duty();
          }
          public override string ToString()
          {
               return base.ToString() + "\n Tenure: " + Tenure;
          }
     }
}
