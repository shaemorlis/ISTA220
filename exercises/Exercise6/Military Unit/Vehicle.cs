using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Vehicle
     {
          private int    VehicleID;
          private float  Heading;
          private Coordinates  Latitude;
          private Coordinates  Longitude;
          private string VehicleName;          

          public void    setVehicleID(int id) { this.VehicleID = id; }
          public int     getVehicleID() { return this.VehicleID; }
          public void setHeading(float head) { this.Heading = head; }
          public float getHeading() { return this.Heading; }
          public void    setVehicleName(string name) { this.VehicleName = name; }
          public string  getVehicleName() { return this.VehicleName; }
          public void    setLatitude(Coordinates lat) { this.Latitude = lat; }
          public Coordinates  getLatitude() { return this.Latitude; }
          public void setLongitude(Coordinates lon) { this.Longitude = lon; }
          public Coordinates getLongitude() { return this.Longitude; }
          public Vehicle()
          {
               //Console.WriteLine("Vehicle Class Constructor called");
          }
          public virtual void ChangeHeading() { }
          public virtual void DeployWeapon() { }
          public override string ToString()
          {
               return /*base.ToString() + */"\n VehicleID: " + VehicleID + "\n Heading: " + Heading + " Degrees " + "\n Latitude: " + Latitude + "\n Longitude: " + Longitude + "\n VehicleName: " + VehicleName;
          }
     }
}
