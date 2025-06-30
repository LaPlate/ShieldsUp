using System;
using System.Collections.Generic;
using Godot;

[GlobalClass]
public partial class CardDatabase : Resource
{
    public Dictionary<int, CardData> cardList = new()
    {
        { 1, new CardData
            {
                CardNum = 1,
                CardTitle = "Basic Action",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic()
            }
        },
        { 2, new CardData
            {
                CardNum = 2,
                CardTitle = "Basic Action - Security",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic()
            }
        },
        { 3, new CardData
            {
                CardNum = 3,
                CardTitle = "Basic Action - Security",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic()
            }
        },
        { 4, new CardData
            {
                CardNum = 4,
                CardTitle = "Basic Action - Shields",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic()
            }
        },
        { 5, new CardData
            {
                CardNum = 5,
                CardTitle = "Basic Action - Shields",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic()
            }
        },
        { 6, new CardData
            {
                CardNum = 6,
                CardTitle = "Basic Action - Engineering",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic()
            }
        },
        { 7, new CardData
            {
                CardNum = 7,
                CardTitle = "Basic Action - Engineering",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic()
            }
        },
        { 8, new CardData
            {
                CardNum = 8,
                CardTitle = "Basic Action - Weapons",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic()
            }
        },
        { 9, new CardData
            {
                CardNum = 9,
                CardTitle = "Basic Action - Weapons",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic()
            }
        }/*,
        { 10, new CardData
            {
                CardNum = 10,
                CardTitle = "Starter Hero?",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic()
            }
        }*/

    };
}