using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MilitaryUnit
{
     public class UnitManager
     {
          public Weapon weaponObj;
          public Vehicle vehicleObj;
          public Mission missionObj;
          public Personnel personnelObj;
          //Constructor
          public UnitManager()
          {
               weaponObj = new Weapon();
               vehicleObj = new Vehicle();
               missionObj = new Mission();
               personnelObj = new Personnel();
               //Console.WriteLine("Unit Class Constructor called");
          }
          public void Manage()
          {
               Console.WriteLine("*************** Base Class Weapon ****************");
               Console.WriteLine("\n");
               //For SmallArms
               Console.WriteLine("*************** Child Class Small Arms ****************");
               Console.WriteLine("\n");
               weaponObj = new SmallArms();               
               weaponObj.setWeaponID(100);
               weaponObj.setWeaponName("AK47");
               weaponObj.setWeaponWeight(3.47f);
               weaponObj.setWeaponUsage("For short Ranges");
               weaponObj.setWeaponRange(0.200f);
               weaponObj.setWeaponEffectiveness("Very effective in short ranges");
               ((SmallArms)weaponObj).setAutomatic(false);
               ((SmallArms)weaponObj).setBullets(390);
               Console.WriteLine(((SmallArms)weaponObj).ToString());
               Console.WriteLine("\n");

               //For LightWeapons
               Console.WriteLine("*************** Child Class Light Weapons ****************");
               Console.WriteLine("\n");
               weaponObj = new LightWeapons(101,"Heavy Machine Gun",38.0f,"For medium Ranges","Very effective for medium ranges",5.0f, true,1000);               
               Console.WriteLine(((LightWeapons)weaponObj).ToString());
               Console.WriteLine("\n");

               //For Explosives
               Console.WriteLine("*************** Child Class Explosives ****************");
               Console.WriteLine("\n");
               weaponObj = new Explosives();
               weaponObj.setWeaponID(102);
               weaponObj.setWeaponName("Missile ");
               weaponObj.setWeaponWeight(1300.0f);
               weaponObj.setWeaponUsage("For long Ranges");
               weaponObj.setWeaponRange(2000.0f);
               weaponObj.setWeaponEffectiveness("Very effective for long ranges");
               ((Explosives)weaponObj).setDestructive(true);
               ((Explosives)weaponObj).setSize(500.0f);
               Console.WriteLine(((Explosives)weaponObj).ToString());
               Console.WriteLine("\n");

               Console.WriteLine("*************** Base Class Vehicle ****************");
               Console.WriteLine("\n");
               //For Coordinates
               Coordinates coord = new Coordinates();
               coord.setPositionX(1);
               coord.setPositionY(2);
               coord.setPositionZ(3);

               //For Aircraft
               Console.WriteLine("*************** Child Class Aircraft ****************");
               Console.WriteLine("\n");
               vehicleObj = new Aircraft();               
               ((Aircraft)vehicleObj).setAltitude(7000.67f);

               //For Fighter
               Console.WriteLine("*************** Sub Child Class Fighter ****************");
               Console.WriteLine("\n");
               vehicleObj = new Fighter();
               vehicleObj.setHeading(180.0f);
               vehicleObj.setLatitude(coord);
               vehicleObj.setLongitude(coord);
               vehicleObj.setVehicleID(200);
               vehicleObj.setVehicleName("Fighter");
               ((Fighter)vehicleObj).setSpeed(7200.0f);
               Console.WriteLine(((Fighter)vehicleObj).ToString());
               Console.WriteLine("\n");


               //For Bomber
               Console.WriteLine("*************** Sub Child Class Bomber ****************");
               Console.WriteLine("\n");
               vehicleObj = new Bomber();
               vehicleObj.setHeading(150.6f);
               vehicleObj.setLatitude(coord);
               vehicleObj.setLongitude(coord);
               vehicleObj.setVehicleID(201);
               vehicleObj.setVehicleName("Bomber");
               ((Bomber)vehicleObj).setWeapon(true);
               Console.WriteLine(((Bomber)vehicleObj).ToString());
               Console.WriteLine("\n");

               //For Ship
               Console.WriteLine("*************** Child Class Ship ****************");
               Console.WriteLine("\n");
               vehicleObj = new Ship();
               ((Ship)vehicleObj).setDepth(300.0f);

               //For Cruiser
               Console.WriteLine("*************** Sub Child Class Cruiser ****************");
               Console.WriteLine("\n");
               vehicleObj = new Cruiser();
               vehicleObj.setHeading(130.5f);
               vehicleObj.setLatitude(coord);
               vehicleObj.setLongitude(coord);
               vehicleObj.setVehicleID(200);
               vehicleObj.setVehicleName("Cruiser");
               ((Cruiser)vehicleObj).setCrew(15);
               Console.WriteLine(((Cruiser)vehicleObj).ToString());
               Console.WriteLine("\n");


               //For Submarine
               Console.WriteLine("*************** Sub Child Class Submarine ****************");
               Console.WriteLine("\n");
               vehicleObj = new Submarine();
               vehicleObj.setHeading(89.6f);
               vehicleObj.setLatitude(coord);
               vehicleObj.setLongitude(coord);
               vehicleObj.setVehicleID(201);
               vehicleObj.setVehicleName("Submarine");
               ((Submarine)vehicleObj).setType("Ballistic missile");
               Console.WriteLine(((Submarine)vehicleObj).ToString());
               Console.WriteLine("\n");

               Console.WriteLine("*************** Base Class Personnel ****************");
               Console.WriteLine("\n");
               //For Uniform
               Console.WriteLine("*************** Child Class Uniform ****************");
               Console.WriteLine("\n");
               personnelObj = new Uniform();
               personnelObj.setAlive(true);
               personnelObj.setFatigue(45);
               personnelObj.setGender("male");
               personnelObj.setHunger(50);
               personnelObj.setPerformance(70);
               personnelObj.setPersonID(300);
               personnelObj.setPersonName("john");
               personnelObj.setRank("commander");
               personnelObj.setStress(60);
               ((Uniform)personnelObj).setTenure(25);
               Console.WriteLine(((Uniform)personnelObj).ToString());
               Console.WriteLine("\n");

               //For NonUniform
               Console.WriteLine("*************** Child Class Non Uniform ****************");
               Console.WriteLine("\n");
               personnelObj = new NonUniform();
               personnelObj.setAlive(true);
               personnelObj.setFatigue(45);
               personnelObj.setGender("male");
               personnelObj.setHunger(50);
               personnelObj.setPerformance(70);
               personnelObj.setPersonID(301);
               personnelObj.setPersonName("eric");
               personnelObj.setRank("Driver");
               personnelObj.setStress(60);
               ((NonUniform)personnelObj).setPersonsCapacity(50);
               Console.WriteLine(((NonUniform)personnelObj).ToString());
               Console.WriteLine("\n");

               Console.WriteLine("*************** Base Class Mission ****************");
               Console.WriteLine("\n");
               //For Team
               Console.WriteLine("*************** Child Class Team ****************");
               Console.WriteLine("\n");
               missionObj = new Team();
               missionObj.setCategory("Alpha");
               missionObj.setDuration(4.5f);
               missionObj.setMissionName("Mission Bravo");
               missionObj.setMissionID(400);
               ((Team)missionObj).setLeaderName("Andrew");
               ((Team)missionObj).setTeamMembers(5);
               ((Team)missionObj).setTeamSignature("hawk");
               Console.WriteLine(((Team)missionObj).ToString());
               Console.WriteLine("\n");
          }
     }
}
