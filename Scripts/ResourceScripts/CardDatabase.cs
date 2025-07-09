using System;
using System.Collections.Generic;
using Godot;

[GlobalClass]
public partial class CardDatabase : Resource
{
    public Dictionary<int, CardData> cardList = new()
    //CardType Conditionals check for True, and then execute the next line. If False, they skip a line. Use with JumpToStep.
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
                        {

                        }
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
                        {
                            InstructionName = "IF: Player Chooses a Station",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            ChoiceOptions = {"Bridge (1)", "Sensors (1)", "Weapons (2)", "Engineering (1)", "Shields (1)", "Cargo (1)", "Medical (1)"},
                            ToStation = { InstructionSet.Station.Security }
                        },

                        new InstructionSet
                        {
                            InstructionName = "Add 2 Energy to Security",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 2, Stuff = {InstructionSet.GameObject.Energy},
                            ToStation = { InstructionSet.Station.Security }
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Add 1 Energy to PlayerSelected Station",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            FromStation =
                            {
                                InstructionSet.Station.Bridge,
                                InstructionSet.Station.Cargo,
                                InstructionSet.Station.Engineering,
                                InstructionSet.Station.SickBay,
                                InstructionSet.Station.Shields,
                                InstructionSet.Station.Sensors
                            },
                            ToStation = { InstructionSet.Station.PlayerChosen }
                        }
                    }
                }
            }
        },
        { 3, new CardData
            {
                CardNum = 3,
                CardTitle = "Basic Action - Security",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "IF: Player Chooses a Station",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            ChoiceOptions = {"Bridge (1)", "Sensors (1)", "Weapons (2)", "Engineering (1)", "Shields (1)", "Cargo (1)", "Medical (1)"},
                            ToStation = { InstructionSet.Station.Security }
                        },

                        new InstructionSet
                        {
                            InstructionName = "Add 2 Energy to Security",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 2, Stuff = {InstructionSet.GameObject.Energy},
                            ToStation = { InstructionSet.Station.Security }
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Add 1 Energy to PlayerSelected Station",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            FromStation =
                            {
                                InstructionSet.Station.Bridge,
                                InstructionSet.Station.Cargo,
                                InstructionSet.Station.Engineering,
                                InstructionSet.Station.SickBay,
                                InstructionSet.Station.Shields,
                                InstructionSet.Station.Sensors
                            },
                            ToStation = { InstructionSet.Station.PlayerChosen }
                        }
                    }
                }
            }
        },
        { 4, new CardData
            {
                CardNum = 4,
                CardTitle = "Basic Action - Shields",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "IF: Player Chooses a Station",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            ChoiceOptions = {"Bridge (1)", "Sensors (1)", "Weapons (1)", "Engineering (1)", "Shields (2)", "Cargo (1)", "Medical (1)"},
                            ToStation = { InstructionSet.Station.Shields }
                        },

                        new InstructionSet
                        {
                            InstructionName = "Add 2 Energy to Shields",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 2, Stuff = {InstructionSet.GameObject.Energy},
                            ToStation = { InstructionSet.Station.Shields }
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Add 1 Energy to PlayerSelected Station",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            FromStation =
                            {
                                InstructionSet.Station.Bridge,
                                InstructionSet.Station.Cargo,
                                InstructionSet.Station.Engineering,
                                InstructionSet.Station.SickBay,
                                InstructionSet.Station.Weapons,
                                InstructionSet.Station.Sensors
                            },
                            ToStation = { InstructionSet.Station.PlayerChosen }
                        }
                    }
                }
            }
        },
        { 5, new CardData
            {
                CardNum = 5,
                CardTitle = "Basic Action - Shields",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "IF: Player Chooses a Station",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            ChoiceOptions = {"Bridge (1)", "Sensors (1)", "Weapons (1)", "Engineering (1)", "Shields (2)", "Cargo (1)", "Medical (1)"},
                            ToStation = { InstructionSet.Station.Shields }
                        },

                        new InstructionSet
                        {
                            InstructionName = "Add 2 Energy to Shields",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 2, Stuff = {InstructionSet.GameObject.Energy},
                            ToStation = { InstructionSet.Station.Shields }
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Add 1 Energy to PlayerSelected Station",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            FromStation =
                            {
                                InstructionSet.Station.Bridge,
                                InstructionSet.Station.Cargo,
                                InstructionSet.Station.Engineering,
                                InstructionSet.Station.SickBay,
                                InstructionSet.Station.Weapons,
                                InstructionSet.Station.Sensors
                            },
                            ToStation = { InstructionSet.Station.PlayerChosen }
                        }
                    }
                }
            }
        },
        { 6, new CardData
            {
                CardNum = 6,
                CardTitle = "Basic Action - Engineering",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "IF: Player Chooses a Station",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            ChoiceOptions = {"Bridge (1)", "Sensors (1)", "Weapons (1)", "Engineering (2)", "Shields (1)", "Cargo (1)", "Medical (1)"},
                            ToStation = { InstructionSet.Station.Engineering }
                        },

                        new InstructionSet
                        {
                            InstructionName = "Add 2 Energy to Engineering",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 2, Stuff = {InstructionSet.GameObject.Energy},
                            ToStation = { InstructionSet.Station.Engineering }
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Add 1 Energy to PlayerSelected Station",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            FromStation =
                            {
                                InstructionSet.Station.Bridge,
                                InstructionSet.Station.Cargo,
                                InstructionSet.Station.Shields,
                                InstructionSet.Station.SickBay,
                                InstructionSet.Station.Weapons,
                                InstructionSet.Station.Sensors
                            },
                            ToStation = { InstructionSet.Station.PlayerChosen }
                        }
                    }
                }
            }
        },
        { 7, new CardData
            {
                CardNum = 7,
                CardTitle = "Basic Action - Engineering",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "IF: Player Chooses a Station",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            ChoiceOptions = {"Bridge (1)", "Sensors (1)", "Weapons (1)", "Engineering (2)", "Shields (1)", "Cargo (1)", "Medical (1)"},
                            ToStation = { InstructionSet.Station.Engineering }
                        },

                        new InstructionSet
                        {
                            InstructionName = "Add 2 Energy to Engineering",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 2, Stuff = {InstructionSet.GameObject.Energy},
                            ToStation = { InstructionSet.Station.Engineering }
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Add 1 Energy to PlayerSelected Station",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            FromStation =
                            {
                                InstructionSet.Station.Bridge,
                                InstructionSet.Station.Cargo,
                                InstructionSet.Station.Shields,
                                InstructionSet.Station.SickBay,
                                InstructionSet.Station.Weapons,
                                InstructionSet.Station.Sensors
                            },
                            ToStation = { InstructionSet.Station.PlayerChosen }
                        }
                    }
                }
            }
        },
        { 8, new CardData
            {
                CardNum = 8,
                CardTitle = "Basic Action - Weapons",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "IF: Player Chooses a Station",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            ChoiceOptions = {"Bridge (1)", "Sensors (1)", "Weapons (2)", "Engineering (1)", "Shields (1)", "Cargo (1)", "Medical (1)"},
                            ToStation = { InstructionSet.Station.Weapons }
                        },

                        new InstructionSet
                        {
                            InstructionName = "Add 2 Energy to Weapons",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 2, Stuff = {InstructionSet.GameObject.Energy},
                            ToStation = { InstructionSet.Station.Weapons }
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Add 1 Energy to PlayerSelected Station",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            FromStation =
                            {
                                InstructionSet.Station.Bridge,
                                InstructionSet.Station.Cargo,
                                InstructionSet.Station.Engineering,
                                InstructionSet.Station.SickBay,
                                InstructionSet.Station.Shields,
                                InstructionSet.Station.Sensors
                            },
                            ToStation = { InstructionSet.Station.PlayerChosen }
                        }
                    }
                }
            }
        },
        { 9, new CardData
            {
                CardNum = 9,
                CardTitle = "Basic Action - Weapons",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "IF: Player Chooses a Station",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            ChoiceOptions = {"Bridge (1)", "Sensors (1)", "Weapons (2)", "Engineering (1)", "Shields (1)", "Cargo (1)", "Medical (1)"},
                            ToStation = { InstructionSet.Station.Weapons }
                        },

                        new InstructionSet
                        {
                            InstructionName = "Add 2 Energy to Weapons",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 2, Stuff = {InstructionSet.GameObject.Energy},
                            ToStation = { InstructionSet.Station.Weapons }
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Add 1 Energy to PlayerSelected Station",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            FromStation =
                            {
                                InstructionSet.Station.Bridge,
                                InstructionSet.Station.Cargo,
                                InstructionSet.Station.Engineering,
                                InstructionSet.Station.SickBay,
                                InstructionSet.Station.Shields,
                                InstructionSet.Station.Sensors
                            },
                            ToStation = { InstructionSet.Station.PlayerChosen }
                        }
                    }
                }
            }
        },
        { 10, new CardData
            {
                CardNum = 10,
                CardTitle = "Asteroid Mining",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Pay the Weapon Power",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = -1, Stuff = {InstructionSet.GameObject.WeaponPower, InstructionSet.GameObject.SecurityPower },
                        },
                        new InstructionSet
                        {
                            InstructionName = "Get the cargo",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCargo,
                            Stuff = { InstructionSet.GameObject.RawOre },
                            Quantity = 1
                        }

                    }
                }
            }
        },
        { 11, new CardData
            {
                CardNum = 11,
                CardTitle = "Deep Scan",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Pay the Sensor Power",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = -1, Stuff = { InstructionSet.GameObject.SensorPower }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Draw three cards",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.DrawCards,
                            Quantity = 3, From = InstructionSet.InstructionFrom.PlayerDeck, To = InstructionSet.InstructionTo.Hand
                        }
                    }
                }
            }
        },
        { 12, new CardData
            {
                CardNum = 12,
                CardTitle = "Fire Chaff!",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Pay the Cargo",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCargo,
                            Quantity = -1
                        },
                        new InstructionSet
                        {
                            InstructionName = "Suppress Incoming Fire",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.ExoticAction // EXOTIC ACTION
                        }
                    }
                }
            }
        },
        {
            13, new CardData
            {
                CardNum = 13,
                CardTitle = "All Power to Shields!",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add Shield Function to all stations",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddStationAbility,
                            FromStation = { InstructionSet.Station.Shields },
                            ToStation = { InstructionSet.Station.All }
                        }
                    }
                }
            }
        },
        {
            14, new CardData
            {
                CardNum = 14,
                CardTitle = "All Power to Engines!",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add Engine Function to all stations",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddStationAbility,
                            FromStation = { InstructionSet.Station.Engineering },
                            ToStation = { InstructionSet.Station.All }
                        }
                    }
                }
            }
        },
        {
            15, new CardData
            {
                CardNum = 15,
                CardTitle = "Alpha Strike",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Multiply Weapons Power by 2.",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.MultiplyResource,
                            Stuff = { InstructionSet.GameObject.WeaponPower },
                            Quantity = 2
                        },
                        new InstructionSet
                        {
                            InstructionName = "Suppress Shield Function",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.SuppressStationAbility,
                            ToStation = { InstructionSet.Station.Shields }
                        }
                    }
                }
            }
        },
        {
            16, new CardData
            {
                CardNum = 16,
                CardTitle = "Emergency Power",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add cards to Player Deck",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCards,
                            IDs = { 17, 18, 19, 20, 21, 22 },
                            Quantity = 1,
                            To = InstructionSet.InstructionTo.PlayerDeck
                        }
                    }
                }
            }
        },
        {
            17, new CardData
            {
                CardNum = 17,
                CardTitle = "Emergency Battery - Bridge",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add one energy to Bridge.",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            ToStation = { InstructionSet.Station.Bridge }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Draw a Card",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.DrawCards,
                            Quantity = 1, From = InstructionSet.InstructionFrom.PlayerDeck, To = InstructionSet.InstructionTo.Hand
                        }
                    }
                }
            }
        },
        {
            18, new CardData
            {
                CardNum = 18,
                CardTitle = "Emergency Battery - Sensors",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add one energy to Sensors.",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            ToStation = { InstructionSet.Station.Sensors }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Draw a Card",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.DrawCards,
                            Quantity = 1, From = InstructionSet.InstructionFrom.PlayerDeck, To = InstructionSet.InstructionTo.Hand
                        }
                    }
                }
            }
        },
        {
            19, new CardData
            {
                CardNum = 19,
                CardTitle = "Emergency Battery - Weapons",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add one energy to Weapons.",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            ToStation = { InstructionSet.Station.Weapons }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Draw a Card",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.DrawCards,
                            Quantity = 1, From = InstructionSet.InstructionFrom.PlayerDeck, To = InstructionSet.InstructionTo.Hand
                        }
                    }
                }
            }
        },
        {
            20, new CardData
            {
                CardNum = 20,
                CardTitle = "Emergency Battery - Medical",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add one energy to Medical.",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            ToStation = { InstructionSet.Station.SickBay }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Draw a Card",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.DrawCards,
                            Quantity = 1, From = InstructionSet.InstructionFrom.PlayerDeck, To = InstructionSet.InstructionTo.Hand
                        }
                    }
                }
            }
        },
        {
            21, new CardData
            {
                CardNum = 21,
                CardTitle = "Emergency Battery - Engineering",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add one energy to Engineering.",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            ToStation = { InstructionSet.Station.Engineering }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Draw a Card",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.DrawCards,
                            Quantity = 1, From = InstructionSet.InstructionFrom.PlayerDeck, To = InstructionSet.InstructionTo.Hand
                        }
                    }
                }
            }
        },
        {
            22, new CardData
            {
                CardNum = 22,
                CardTitle = "Emergency Battery - Shields",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add one energy to Shields.",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.Energy },
                            ToStation = { InstructionSet.Station.Shields }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Draw a Card",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.DrawCards,
                            Quantity = 1, From = InstructionSet.InstructionFrom.PlayerDeck, To = InstructionSet.InstructionTo.Hand
                        }
                    }
                }
            }
        },
        {
            23, new CardData
            {
                CardNum = 23,
                CardTitle = "Scout Probe",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Reveal two Threats",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.RevealCards,
                            Quantity = 2, From = InstructionSet.InstructionFrom.ThreatDeck
                        }
                    }
                }
            }
        }
    };
}