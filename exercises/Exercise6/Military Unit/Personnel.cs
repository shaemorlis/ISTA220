using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
     public class Personnel
     {
          private int PersonID;
          private string PersonName;
          private string Rank;
          private string Gender;
          private double Fatigue;
          private double Hunger;
          private double Stress;
          private double Performance;
          private bool alive;
          public void setFatigue(double fat) { this.Fatigue = fat; }
          public double getFatigue() { return this.Fatigue; }
          public void setHunger(double hun) { this.Hunger = hun; }
          public double getHunger() { return this.Hunger; }
          public void setStress(double str) { this.Stress = str; }
          public double getStress() { return this.Stress; }
          public void setPerformance(double per) { this.Performance = per; }
          public double getPerformance() { return this.Performance; }
          public void setAlive(bool ali) { this.alive = ali; }
          public bool getAlive() { return this.alive; }
          public void setPersonID(int id) { this.PersonID = id; }
          public int getPersonID() { return this.PersonID; }
          public void setPersonName(string name) { this.PersonName = name; }
          public string getPersonName() { return this.PersonName; }
          public void setGender(string gen) { this.Gender = gen; }
          public string getGender() { return this.Gender; }
          public void setRank(string ran) { this.Rank = ran; }
          public string getRank() { return this.Rank; }

          public Personnel()
          {
               //Console.WriteLine("Personnel class Constructor called");
          }
          public virtual void Duty() { }
          public override string ToString()
          {
               return /*base.ToString() +*/ "\n PersonID: " + PersonID + "\n PersonName: " + PersonName + "\n Rank: " + Rank + "\n Gender: " + Gender + "\n Fatigue: " + Fatigue + "\n Hunger: " + Hunger + "\n Stress: " + Stress + "\n Performance: " + Performance + "\n Alive: " + alive;
          }
     }
}                                    