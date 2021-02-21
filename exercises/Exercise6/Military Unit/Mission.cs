using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
     public class Mission
     {
          private int         MissionID;
          private string      MissionName;
          private float    Duration;
          private string      Category;
          public void setMissionID(int id) { this.MissionID = id; }
          public int getMissionID() { return this.MissionID; }
          public void setMissionName(string name) { this.MissionName = name; }
          public string getMissionName() { return this.MissionName; }
          public void setDuration(float dur) { this.Duration = dur; }
          public float getDuration() { return this.Duration; }
          public void setCategory(string cat) { this.Category = cat; }
          public string getCategory() { return this.Category; }
          public Mission()
          {
               //Console.WriteLine("Mission Class Constructor called");      
          }
          public virtual void Task() { }
          public virtual void Payload() { }
          public override string ToString()
          {
               return /*base.ToString() +*/ "\n MissionID: " + MissionID + "\n MissionName: " + MissionName + "\n Duration: " + Duration + "\n Category: " + Category;
          }
     }
}
