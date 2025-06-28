using Godot;
using System;

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public partial class CardFactory : Node
{
    public Dictionary<string, StandardMaterial3D> cardBackArt = new();

    public override void _Ready()
    {
        cardBackArt["Player"] = GD.Load<StandardMaterial3D>("res://Resources/CardArt/Player_CardArt_Back.tres");

    }
    public Node3D CreateCard(CardData data, Dictionary<string, StandardMaterial3D> backs)
    {
        var completedCard = GD.Load<PackedScene>("res://Scenes/card.tscn").Instantiate<Card>();
        var cardFrontBase = GD.Load<StandardMaterial3D>($"res://Resources/CardArt/{data.CardArtBack}_CardFront_Base.tres");

        completedCard.cardData = data;
        var mesh = completedCard.GetNode<MeshInstance3D>("CardMesh3D");

        switch (completedCard.cardData.CardArtBack)
        {
            case CardData.cardArtBack.Player:
                mesh.SetSurfaceOverrideMaterial(3, backs["Player"]);
                break;

        }

        string faceArtLink = $"res://Assets/Skins/Cards/{completedCard.cardData.CardArtBack}/Player_Card_{completedCard.cardData.CardNum}";
        var texture = GD.Load<Texture2D>(faceArtLink);

        if (texture == null)
        {
            GD.PushError($"ERROR: Could not locate Card Art for {completedCard.cardData.CardTitle} at {faceArtLink}");
        }

        var faceMat = cardFrontBase.Duplicate() as StandardMaterial3D;
        faceMat.AlbedoTexture = texture;

        mesh.SetSurfaceOverrideMaterial(2, faceMat);

        return completedCard;



    }
}
