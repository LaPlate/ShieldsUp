using Godot;
using System;

public partial class Card : Node3D
{
    public CardData cardData { get; set; }

    public void Highlight(bool On)
    {
        if (On)
        {
            GD.Print("Card is highlighted!");
        }
        else
        {
            GD.Print("Card isn't highlighted anymore...");
        }
    }
}
