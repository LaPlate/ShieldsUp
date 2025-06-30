using Godot;
using System;

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Reflection.Metadata;

public partial class CardFactory : Node
{
    public Dictionary<string, StandardMaterial3D> cardTypeArt = new();

    public override void _Ready()
    {
        cardTypeArt["Player"] = GD.Load<StandardMaterial3D>("res://Resources/CardArt/Player_CardArt_Back.tres");
        cardTypeArt["Threat"] = GD.Load<StandardMaterial3D>("res://Resources/CardArt/Threat_CardArt_Back.tres");
        cardTypeArt["Event"] = GD.Load<StandardMaterial3D>("res://Resources/CardArt/Event_CardArt_Back.tres");
        cardTypeArt["Special"] = GD.Load<StandardMaterial3D>("res://Resources/CardArt/Special_CardArt_Back.tres");

    }
    public Card CreateCard(CardData data)
    {
        var completedCard = GD.Load<PackedScene>("res://Scenes/card.tscn").Instantiate<Card>();
        var cardFrontBase = GD.Load<StandardMaterial3D>($"res://Resources/CardArt/{data.CardType}_CardFront_Base.tres");
        var cardFrontArt = new StandardMaterial3D();
        var cardBackArt = new StandardMaterial3D();

        completedCard.cardData = data;
        MeshInstance3D mesh = completedCard.GetNode<MeshInstance3D>("RigidBody3D/CardMesh3D");
        //This node is a busted BoxNode3D, but we replace it immediately during CreateCard with an ArrayMesh!

        switch (completedCard.cardData.CardType) //Maps the resource references to the matching key in the dictionary 'cardTypeArt' populated during _Ready.
        {
            case CardData.cardType.Player:
                cardBackArt = cardTypeArt["Player"];
                break;

            case CardData.cardType.Threat:
                cardBackArt = cardTypeArt["Threat"];
                break;

            case CardData.cardType.Event:
                cardBackArt = cardTypeArt["Event"];
                break;

            case CardData.cardType.Special:
                cardBackArt = cardTypeArt["Special"];
                break;

        }

        //Creates and Confirms the .png to get pasted over the base front art of the new Card.
        string faceArtLink = $"res://Assets/Skins/Cards/{completedCard.cardData.CardType}/Player_Card_{completedCard.cardData.CardNum}.png";
        var faceTexture = GD.Load<Texture2D>(faceArtLink);

        if (faceTexture == null)
        {
            GD.PushError($"ERROR: Could not locate Card Art for {completedCard.cardData.CardTitle} at {faceArtLink}");
        }

        var faceMat = cardFrontBase.Duplicate() as StandardMaterial3D;
        cardFrontArt.AlbedoTexture = faceTexture;
        Texture2D backTexture = cardBackArt.AlbedoTexture;

        ArrayMesh newArrayMesh = CreateCardMesh();
        mesh.Mesh = newArrayMesh;  //GET OUT OF HERE, BOXMESH
        mesh.SetSurfaceOverrideMaterial(0, cardFrontArt);
        mesh.SetSurfaceOverrideMaterial(1, cardBackArt);

        return completedCard;

    }

    public static ArrayMesh CreateCardMesh()
    {
        var mesh = new ArrayMesh();

        // Front face (facing +Z)
        var frontVertices = new Vector3[] {
            new Vector3(-0.5f, 0.75f, 0f),
            new Vector3(0.5f, 0.75f, 0f),
            new Vector3(-0.5f, -0.75f, 0f),
            new Vector3(0.5f, -0.75f, 0f),
        };

        var frontUVs = new Vector2[] {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(1, 1),
        };

        var frontIndices = new int[] { 0, 1, 2, 2, 1, 3 };

        var frontArrays = new Godot.Collections.Array();
        frontArrays.Resize((int)Mesh.ArrayType.Max);
        frontArrays[(int)Mesh.ArrayType.Vertex] = frontVertices;
        frontArrays[(int)Mesh.ArrayType.TexUV] = frontUVs;
        frontArrays[(int)Mesh.ArrayType.Index] = frontIndices;

        mesh.AddSurfaceFromArrays(Mesh.PrimitiveType.Triangles, frontArrays);

        // Back face (facing -Z)
        var backVertices = new Vector3[] {
            new Vector3(0.5f, 0.75f, 0f),
            new Vector3(-0.5f, 0.75f, 0f),
            new Vector3(0.5f, -0.75f, 0f),
            new Vector3(-0.5f, -0.75f, 0f),
        };

        var backUVs = new Vector2[] {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(1, 1),
        };

        var backIndices = new int[] { 0, 1, 2, 2, 1, 3 };

        var backArrays = new Godot.Collections.Array();
        backArrays.Resize((int)Mesh.ArrayType.Max);
        backArrays[(int)Mesh.ArrayType.Vertex] = backVertices;
        backArrays[(int)Mesh.ArrayType.TexUV] = backUVs;
        backArrays[(int)Mesh.ArrayType.Index] = backIndices;

        mesh.AddSurfaceFromArrays(Mesh.PrimitiveType.Triangles, backArrays);

        return mesh;
    }
    public Card DrawRandomCard(CardData.cardType type)
    {
        var filteredCardDB = new CardDatabase();
        var filteredCards = filteredCardDB.cardList.Values
            .Where(card => card.CardType == type)
            .ToList();

        if (filteredCards.Count == 0)
        {
            GD.Print("No cards match the type" + type.ToString());
            return null;
        }

        var randomInt = GD.RandRange(0.0f, filteredCards.Count);
        CardData chosenCard = filteredCards[(int)randomInt - 1];

        return CreateCard(chosenCard);
    }
}
