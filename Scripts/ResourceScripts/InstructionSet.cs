using System.Collections.Generic;
using Godot;

[GlobalClass]
public partial class InstructionSet : Node
{
    public string InstructionName { get; set; }

    public enum InstructionType { Execute, Conditional, JumpToStep }
    public enum InstructionAction
    {
        DrawCards, ExileCards, DiscardCards, PickCards, RevealCards, RevealCardsUntil, AddCards,
        AddResource, MultiplyResource, AddCargo, AddStationAbility, SuppressStationAbility, AddDamage,
        CreateAwayMission, JumpToStep, ExoticAction, AddXP, PlayerChoice,
        AttackPLayer, RemoveThreat, DamageThreat, RemoveBoarders, RemoveTorpedoes
    }
    public enum InstructionFrom
    { Hand, PlayerDeck, PlayerDiscard, EventDeck, ThreatDeck, CardAtStation, Station, ActiveThreats, AvailableChoices, Revealed, RandomCrew }

    public enum GameObject
    {
        Energy, WeaponPower, ShieldPower, Armor, EnginePower, SecurityPower, SensorPower, SickBayPower, CargoPower, PowerPlantPower,
        Hazard, Enemy, RawOre, TradeGoods, PreciousMinerals, Station
    }
    public enum Station { Bridge, Weapons, Security, Engineering, Cargo, SickBay, Shields, Sensors, PlayerChosen, Random, All }

    public enum InstructionTo
    {
        Station, Hand, PlayerDeck, PlayerDiscard, EventDeck, ThreatDeck, CardAtStation, AvailableChoices, PlayerChoices
    }

    public InstructionType InstructionLineType { get; set; }
    public int Quantity { get; set; }
    public List<string> ChoiceOptions { get; set; }
    public List<int> IDs { get; set; }
    public bool EndProcessingAfterThisInstruction;
    public InstructionAction Instruction { get; set; }
    public InstructionFrom From { get; set; }
    public InstructionTo To { get; set; }
    public List<GameObject> Stuff { get; set; }
    public InstructionType Type { get; set; }
    public List<Station> FromStation { get; set; }
    public List<Station> ToStation { get; set; }
}