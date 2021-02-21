using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Team:Mission
     {
          private string LeaderName;
          private int    TeamMembers;
          private string TeamSignature;

          public void setLeaderName(string name) { this.LeaderName = name; }
          public string getLeaderName() { return this.LeaderName; }
          public void setTeamMembers(int mem) { this.TeamMembers = mem; }
          public int getTeamMembers() { return this.TeamMembers; }
          public void setTeamSignature(string sign) { this.TeamSignature = sign; }
          public string getTeamSignature() { return this.TeamSignature; }

          public Team()
          {
              // Console.WriteLine("Team Class Constructor called");
          }
          public override void Task()
          {
               base.Task();
          }
          public override void Payload()
          {
               base.Payload();
          }
          public override string ToString()
          {
               return base.ToString() + "\n LeaderName: " + LeaderName + "\n TeamMembers: " + TeamMembers + "\n TeamSignature: " + TeamSignature;
          }
     }
}
