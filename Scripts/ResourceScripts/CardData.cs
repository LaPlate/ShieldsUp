using Godot;

[GlobalClass]
public partial class CardData : Resource
{

    public enum cardArtBack {Player, Threat, Event, Special}

    [Export]
    public string CardTitle { get; set; }
    [Export]
    public int CardNum { get; set; }
    [Export]
    public string CartArtPath { get; set; }
    [Export]
    public cardArtBack CardArtBack { get; set; }

}