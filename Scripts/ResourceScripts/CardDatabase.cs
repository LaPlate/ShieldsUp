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
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {InstructionName = "Choose Station to Power", Type = InstructionSet.InstructionType.Execute, Instruction = InstructionSet.InstructionAction.PlayerChoice, Resource = InstructionSet.InstructionActionResource.Station},
                        new InstructionSet
                        { InstructionName = "Send Energy to Selected Station (1)", Type = InstructionSet.InstructionType.Execute, Instruction = InstructionSet.InstructionAction.AddResource, Resource = InstructionSet.InstructionActionResource.Energy, Quantity = 1, TargetStation = InstructionSet.InstructionStationTarget.PlayerChosen, EndProcessingAfterThisInstruction = true }
                        
                    }
                }
            }
        },
        { 2, new CardData
            {
                CardNum = 2,
                CardTitle = "Basic Action - Security",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        { InstructionName = "Choose Station to Power", Type = InstructionSet.InstructionType.Execute, Instruction = InstructionSet.InstructionAction.PlayerChoice, Resource = InstructionSet.InstructionActionResource.Station, Quantity = 1 },
                        new InstructionSet
                        { InstructionName = "IF: Player selected Weapons/Security", Type = InstructionSet.InstructionType.Conditional, Instruction = InstructionSet.InstructionAction.PlayerChoice, TargetStation = InstructionSet.InstructionStationTarget.Security },
                        new InstructionSet
                        { InstructionName = "Extra Power to Security", Type = InstructionSet.InstructionType.Execute, Instruction = InstructionSet.InstructionAction.AddResource, Resource = InstructionSet.InstructionActionResource.Energy, TargetStation = InstructionSet.InstructionStationTarget.Security, Quantity = 2, EndProcessingAfterThisInstruction = true },
                        new InstructionSet
                        { InstructionName = "ELSE: Send Energy to Selected Station (1)", Type = InstructionSet.InstructionType.Execute, Instruction = InstructionSet.InstructionAction.AddResource, Resource = InstructionSet.InstructionActionResource.Energy, Quantity = 1, TargetStation = InstructionSet.InstructionStationTarget.PlayerChosen, EndProcessingAfterThisInstruction = true}                    
                    }
                }
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