using Godot;

[GlobalClass]
public partial class CardData : Resource
{

    public enum cardType {Player, Threat, Event, Special}

    [Export]
    public string CardTitle { get; set; }
    [Export]
    public int CardNum { get; set; }
    [Export]
    public cardType CardType { get; set; }

}