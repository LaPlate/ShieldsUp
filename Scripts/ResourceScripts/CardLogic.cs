using System;
using System.Collections.Generic;
using Godot;

[GlobalClass]
public partial class CardLogic : Resource
{
    public List<InstructionSet> Instructions;
    public enum CrewType { Captain, FirstMate, Officer, Tech, Security, Pilot }

    public List<CrewType> crewTypes;

    public enum AllowedStation { Bridge, Sensors, Shields, Weapons, SickBay, Cargo, Engineering }

    public List<AllowedStation> allowedStations;

}