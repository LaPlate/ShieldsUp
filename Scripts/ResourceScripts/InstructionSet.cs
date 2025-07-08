using System.Collections.Generic;
using Godot;

[GlobalClass]
public partial class InstructionSet : Node
{
    public string InstructionName { get; set; }

    public enum InstructionType { Execute, Conditional }
    public enum InstructionAction { Draw, Exile, Discard, AddResource, ReplaceStation, PromoteCard, PlayerChoice, JumpToStep, ExoticAction }
    public enum InstructionActionResource
    {
        CardInHand, CardInDeck, CardinDiscard, CardinExile, CardsDrawnPerTurn, CardAtStation,
        Energy, WeaponPower, ShieldPower, Armor, EnginePower, SecurityPower, ScannerPower, SickBayPower,
        Hazard, Enemy, Cargo, Station
    }
    public enum InstructionStationTarget { Bridge, Weapons, Security, Engineering, Cargo, SickBay, Shields, Sensors, PlayerChosen, Random }

    public int Quantity { get; set; }
    public List<string> ChoiceOptions { get; set; }
    public List<int> TargetEntityIDList { get; set; }
    public bool EndProcessingAfterThisInstruction;

    public InstructionAction Instruction { get; set; }
    public InstructionActionResource Resource { get; set; }

    public InstructionType Type { get; set; }
    
    public InstructionStationTarget TargetStation { get; set; }
}