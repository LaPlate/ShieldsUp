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
                            Instruction = InstructionSet.InstructionAction.ExoticAction // EXOTIC ACTION: Suppress enemy attack effects
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
        },
        {
            24, new CardData
            {
                CardNum = 24,
                CardTitle = "Trading Vessel",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Spend a Trade Good",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCargo,
                            Quantity = -1, Stuff = { InstructionSet.GameObject.TradeGoods }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Gain a Precious Minerals",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCargo,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.PreciousMinerals }
                        }
                    }
                }
            }
        },
        { 25, new CardData
            {
                CardNum = 25,
                CardTitle = "Hide in Debris",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Test for Distance",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.ExoticAction, // EXOTIC ACTION: Test Enemy Distances
                            From = InstructionSet.InstructionFrom.ActiveThreats,
                            To = InstructionSet.InstructionTo.AvailableChoices
                        },
                        new InstructionSet
                        {
                            InstructionName = "Choose a Threat to Hide From",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            Instruction = InstructionSet.InstructionAction.PlayerChoice,
                            From = InstructionSet.InstructionFrom.AvailableChoices,
                            To = InstructionSet.InstructionTo.PlayerChoices,
                        },
                        new InstructionSet
                        {
                            InstructionName = "Remove the Threat",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.RemoveThreat
                        },
                        new InstructionSet
                        {
                            InstructionName = "Suppress Engines and Weapons",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.SuppressStationAbility,
                            ToStation = { InstructionSet.Station.Weapons, InstructionSet.Station.Engineering }
                        }
                    }
                }
            }
        },
        { 26, new CardData
            {
                CardNum = 26,
                CardTitle = "Damage Control",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Spend the Energy",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = -2, Stuff = { InstructionSet.GameObject.Energy }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Choose the Station to Repair",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddDamage,
                            Quantity = -2, ToStation = { InstructionSet.Station.PlayerChosen }
                        }
                    }
                }
            }
        },
        { 27, new CardData
            {
                CardNum = 27,
                CardTitle = "Derelict Spacecraft",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Pay for the Cargo - 1st Time",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = -2, Stuff = { InstructionSet.GameObject.Energy }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Add 1 Cargo - 1st Time",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCargo,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.TradeGoods }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Query to Repeat",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            Instruction = InstructionSet.InstructionAction.PlayerChoice,
                            ChoiceOptions = { "Yes - Spend another 2 Energy", "No" },
                        },
                        new InstructionSet
                        {
                            InstructionName = "Jump past Terminus",
                            InstructionLineType = InstructionSet.InstructionType.JumpToStep,
                            Quantity = 5
                        },
                        new InstructionSet
                        {
                            InstructionName = "Terminus",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            EndProcessingAfterThisInstruction = true
                        },
                        new InstructionSet
                        {
                            InstructionName = "Pay for the Cargo - 2nd Time",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = -2, Stuff = { InstructionSet.GameObject.Energy }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Add 1 Cargo - 2nd Time",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCargo,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.TradeGoods }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Query to Repeat",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            Instruction = InstructionSet.InstructionAction.PlayerChoice,
                            ChoiceOptions = { "Yes - Spend another 2 Energy", "No" },
                        },
                        new InstructionSet
                        {
                            InstructionName = "Jump past Terminus",
                            InstructionLineType = InstructionSet.InstructionType.JumpToStep,
                            Quantity = 10
                        },
                        new InstructionSet
                        {
                            InstructionName = "Terminus",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            EndProcessingAfterThisInstruction = true
                        },
                        new InstructionSet
                        {
                            InstructionName = "Pay for the Cargo - 3rd Time",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = -2, Stuff = { InstructionSet.GameObject.Energy }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Add 1 Cargo - 3rd Time",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCargo,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.TradeGoods }
                        }
                    }
                }
            }
        },
        {
            28, new CardData
            {
                CardNum = 28,
                CardTitle = "Sensik Premonition",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Reveal the next Event",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.RevealCards,
                            Quantity = 1, From = InstructionSet.InstructionFrom.EventDeck
                        },
                        new InstructionSet
                        {
                            InstructionName = "Query: top of deck or 10 deep",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            Instruction = InstructionSet.InstructionAction.PlayerChoice,
                            ChoiceOptions = {" Put back on Top", "Place 10 Cards in" }
                        },
                        new InstructionSet
                        {
                            InstructionName = "If True, Do nothing",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            EndProcessingAfterThisInstruction = true
                        },
                        new InstructionSet
                        {
                            InstructionName = "Put Card 10 Cards in",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.ExoticAction, //EXOTIC ACTION: Put top card 10 cards in
                            To = InstructionSet.InstructionTo.EventDeck
                        }
                    }
                }
            }
        },
        { 29, new CardData
            {
                CardNum = 29,
                CardTitle = "Sensik Foreboding",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Sensik Foreboding",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.RevealCardsUntil,
                            From = InstructionSet.InstructionFrom.ThreatDeck,
                            Stuff = { InstructionSet.GameObject.Enemy }
                        }
                    }
                }
            }
        },
        { 30, new CardData
            {
                CardNum = 30,
                CardTitle = "Sensik Foretelling",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Reveal the top card of the Player deck.",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.RevealCards,
                            Quantity = 1, From = InstructionSet.InstructionFrom.PlayerDeck
                        },
                        new InstructionSet
                        {
                            InstructionName = "IF: Player Chooses to put it in hand",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            ChoiceOptions = { "Add to Hand", "Bottom of Deck" },
                            Instruction = InstructionSet.InstructionAction.PlayerChoice
                        },
                        new InstructionSet
                        {
                            InstructionName = "THEN: Draw the card",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.DrawCards,
                            Quantity = 1, From = InstructionSet.InstructionFrom.PlayerDeck, To = InstructionSet.InstructionTo.Hand,
                            EndProcessingAfterThisInstruction = true
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Put the card on the bottom of the deck",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.ExoticAction, //EXOTIC ACTION Put card on bottom of deck (c'mon...)
                            From = InstructionSet.InstructionFrom.PlayerDeck, To = InstructionSet.InstructionTo.PlayerDeck,
                            Quantity = 1
                        }
                    }
                }
            }

        },
        { 31, new CardData

            {
                CardNum = 31,
                CardTitle = "Encountered Conflict",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Player decides what to do",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            ChoiceOptions = { "Do nothing", "Intervene ( Reveal an enemy vessel)" },
                            Instruction = InstructionSet.InstructionAction.PlayerChoice
                        },
                        new InstructionSet
                        {
                            InstructionName = "Terminus",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            EndProcessingAfterThisInstruction = true
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Reveal Threats until Enemy Vessel is found",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.RevealCardsUntil,
                            Stuff = { InstructionSet.GameObject.Enemy }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Put Threat into Play",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.DrawCards,
                            Quantity = 1, From = InstructionSet.InstructionFrom.Revealed
                        },
                        new InstructionSet
                        {
                            InstructionName = "Give player choice of Trade Goods or Minerals",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            Instruction = InstructionSet.InstructionAction.PlayerChoice,
                            ChoiceOptions = { "2 Trade Goods", "1 Precious Minerals" }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Give player 2 Trade Goods and Terminate",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCargo,
                            Stuff = { InstructionSet.GameObject.TradeGoods }, Quantity = 2,
                            EndProcessingAfterThisInstruction = true
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Give the player 1 Precious Minerals",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCargo,
                            Stuff = { InstructionSet.GameObject.PreciousMinerals }, Quantity = 1
                        }
                    }
                }
            }
        },
        { 32, new CardData
            {
                CardNum = 32,
                CardTitle = "In Need of Rescue",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Player decides whether to intervene",
                            InstructionLineType = InstructionSet.InstructionType.Conditional,
                            ChoiceOptions = { "Do nothing", "Mount a Rescue! (3 Security, 1 cargo)" },
                            Instruction = InstructionSet.InstructionAction.PlayerChoice
                        },
                        new InstructionSet
                        {
                            InstructionName = "IF: Player does nothing",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            EndProcessingAfterThisInstruction = true
                        },
                        new InstructionSet
                        {
                            InstructionName = "ELSE: Spend three Security power",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Stuff = { InstructionSet.GameObject.SecurityPower }, Quantity = -3
                        },
                        new InstructionSet
                        {
                            InstructionName = "Take the cargo",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCargo,
                            Quantity = -1
                        },
                        new InstructionSet
                        {
                            InstructionName = "Gain a random Crewmember",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddCards,
                            Quantity = 1,
                            From = InstructionSet.InstructionFrom.RandomCrew,
                            To = InstructionSet.InstructionTo.Hand
                        },
                        new InstructionSet
                        {
                            InstructionName = "Everyone gets 10XP",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddXP,
                            Quantity = 10, To = InstructionSet.InstructionTo.CardAtStation,
                            ToStation = { InstructionSet.Station.All }
                        }

                    }
                }
            }
        },
        { 33, new CardData
            {
                CardNum = 33,
                CardTitle = "Security Simulations",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add two Security Power",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 2, Stuff = { InstructionSet.GameObject.SecurityPower }
                        }
                    }
                }
            }
        },
        { 34, new CardData
            {
                CardNum = 34,
                CardTitle = "Close Combat Drills",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add two Cargo Power",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 2, Stuff = { InstructionSet.GameObject.CargoPower }
                        },
                        new InstructionSet
                        {
                            InstructionName = "Add one Weapons Power",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.WeaponPower }
                        }
                    }
                }
            }
        },
        { 35, new CardData
            {
                CardNum = 35,
                CardTitle = "Improved Propulsion Techniques",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add two Engineering Power",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 2, Stuff = { InstructionSet.GameObject.EnginePower }
                        }
                    }
                }
            }
        },
        { 36, new CardData
            {
                CardNum = 36,
                CardTitle = "Redline the Power Plant",
                CardType = CardData.cardType.Player,
                cardLogic = new CardLogic
                {
                    Instructions = new List<InstructionSet>
                    {
                        new InstructionSet
                        {
                            InstructionName = "Add One PowerPlant Power",
                            InstructionLineType = InstructionSet.InstructionType.Execute,
                            Instruction = InstructionSet.InstructionAction.AddResource,
                            Quantity = 1, Stuff = { InstructionSet.GameObject.PowerPlantPower }
                        }
                    }
                }
            }
        }

    };
}