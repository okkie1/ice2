using System.Reflection.Metadata;
using System.Security.Principal;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace ice2
{
    internal class Program
    {
        private static string gameChoice;
        CheeseBurger choice = new CheeseBurger();

        public static string Storychoice { get; private set; }

        static void Main(string[] args)
        {
            CheeseBurger choice = new CheeseBurger();

            //Set the console background and foreground colors
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            

            // Create a new SpeechSynthesizer instancw
            SpeechSynthesizer synth = new SpeechSynthesizer();

            //set the voice to the defualt system voice
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

            //Introduction with colored text
            PrintWithColor(synth, "Welcome to the "+ choice.getstorychoice + " 2 way pass Story Narrator!", ConsoleColor.Yellow);

            //start the story
            StartStory(synth);

            // Farewell message with colored text
            PrintWithColor(synth, "Thank you for exploring with us! " +
                "Remember not to return here!!!!", ConsoleColor.Green);

            static void StartStory(SpeechSynthesizer synth)
            {
                CheeseBurger choice = new CheeseBurger();
                PrintWithColor(synth, "You find yourself at a two way pass. " +
                    "Do you want to go to the 'forest' pass or the 'highway' pass ?", ConsoleColor.Cyan);
                
                Console.WriteLine("Type 'Highway' or 'Forest'");
                choice.gameChoice = Console.ReadLine().ToLower(); ;
                

                if (choice.gameChoice == "highway")
                {
                    PrintWithColor(synth, "You take the highway pass and walk next to the road." +
                        "But suddenly someone stops next to you and asks for directions do you give 'directions' or 'run' away"
                        , ConsoleColor.Cyan);
                    choice.gameChoice = Console.ReadLine().ToLower();

                    if (choice.gameChoice == "directions")
                    {
                        PrintWithColor(synth, "You give direction but get dragged in the car. " +
                            " You wake up and find youself in the passenger seat tied up", ConsoleColor.Green);
                        PrintWithColor(synth, "You see a chance to kick the driver in the face do you 'do it'" +
                            " or do you 'not do it'.", ConsoleColor.Green);
                        choice.gameChoice = Console.ReadLine().ToLower();
                        if (choice.gameChoice == "do it")
                        {
                            PrintWithColor(synth, "You kick the driver and you crash. You wake up outside the car seeing the driver" +
                                "dead walking back to the road and off to a hosital. You Survive!!! "
                       , ConsoleColor.Green);

                        }
                        else if (choice.gameChoice == "not do it")
                        {
                            PrintWithColor(synth, "You don't kick him and you go to his cabin in the woods" +
                                "It is revealed he is a moster. You get eaten. You die!!", ConsoleColor.Red);
                            StartStory(synth);
                        }
                        else
                        {
                            PrintWithColor(synth, "Invalid choice", ConsoleColor.Red);
                            StartStory(synth);
                        }
                    }
                    else if (choice.gameChoice == "run")
                    {
                        PrintWithColor(synth, "You run as fast as possible but get hit with the car and die. " +
                            "The end.", ConsoleColor.Red);
                        StartStory(synth);
                    }
                    else
                    {
                        PrintWithColor(synth, "Invalid choice. Please restart the story.", ConsoleColor.Red);
                        StartStory(synth);

                    }
                }
                else if (choice.gameChoice == "forest")
                {
                    PrintWithColor(synth, "You explore the forest of torture and encounter a monster. " +
                        "Do you want to befriend it or run away?", ConsoleColor.Cyan);
                    Console.WriteLine("Type 'befriend' or 'run':");
                    choice.gameChoice = Console.ReadLine().ToLower();

                    if (choice.gameChoice == "befriend")
                    {
                        PrintWithColor(synth, "You befriend the monster. "
                           , ConsoleColor.Green);

                        PrintWithColor(synth, "The monster asks: 'Do you want to hear a joke?'", ConsoleColor.Cyan);
                        choice.gameChoice = Console.ReadLine().ToLower();

                        if (choice.gameChoice == "yes")
                        {
                            PrintWithColor(synth, "Knock Knock ", ConsoleColor.Green);
                            choice.gameChoice = Console.ReadLine().ToLower();
                            if (choice.gameChoice == "who is there")
                            {
                                PrintWithColor(synth, "I am!! The moster laughs in a evil tone "
                                , ConsoleColor.Green);
                                PrintWithColor(synth, "You see a gun in the distance to you 'take' it or 'leave' the gun  "
                                , ConsoleColor.Green);
                                choice.gameChoice = Console.ReadLine().ToLower();
                                if (choice.gameChoice == "take")
                                {
                                    PrintWithColor(synth, "You pckk up the gun and kill the monster. You Survive!!!! "
                               , ConsoleColor.Green);

                                }
                                else if (choice.gameChoice == "leave")
                                {
                                    PrintWithColor(synth, "You don't pick up the gun and later the monster eats you. You lose!!!", ConsoleColor.Red);
                                    StartStory(synth);
                                }
                                else
                                {
                                    PrintWithColor(synth, "Invalid choice", ConsoleColor.Red);
                                    StartStory(synth);
                                }
                            }
                            else
                            {
                                PrintWithColor(synth, "You get eaten. You lose!!!!", ConsoleColor.Red);
                                StartStory(synth);
                            }
                        }
                        else if (choice.gameChoice == "no")
                        {
                            PrintWithColor(synth, "Monster gets mad and kills you. The End", ConsoleColor.Red);
                        }
                        else
                        {
                            PrintWithColor(synth, "Invalid choice", ConsoleColor.Red);
                            StartStory(synth);
                        }


                    }
                    else if (choice.gameChoice == "run")
                    {
                        PrintWithColor(synth, "You run away. But fall of a cliff!!!", ConsoleColor.Red);

                        PrintWithColor(synth, "You wake up from the fall hearing strange noises in a gap between te caynon walls" +
                            " this is your only exit. Do you 'exit' the cave or 'stay'.", ConsoleColor.Cyan);
                        choice.gameChoice = Console.ReadLine().ToLower();

                        if (choice.gameChoice == "exit")
                        {
                            PrintWithColor(synth, "You take the exit and see a lady stuck on some rock that is keeping her arm stuck." +
                                "Do you 'free' her or 'leave' her. "
                           , ConsoleColor.Green);
                            choice.gameChoice = Console.ReadLine().ToLower();
                            if (choice.gameChoice == "free")
                            {
                                PrintWithColor(synth, "You manage to free her and you both fall in love and life happy ever after." +
                                    "You get married and grow old together. "
                           , ConsoleColor.Green);
                            }
                            else if (choice.gameChoice == "leave")
                            {
                                PrintWithColor(synth, "You Leave her behind she dies and you are lost and die. The end!!!", ConsoleColor.Red);
                                StartStory(synth);
                            }
                            else
                            {
                                PrintWithColor(synth, "Invalid choice", ConsoleColor.Red);
                                StartStory(synth);
                            }
                        }
                        else if (choice.gameChoice == "stay")
                        {
                            PrintWithColor(synth, "You died there with the stange noise. The End", ConsoleColor.Red);
                            StartStory(synth);
                        }
                        else
                        {
                            PrintWithColor(synth, "Invalid choice", ConsoleColor.Red);
                            StartStory(synth);
                        }
                    }
                    else
                    {
                        PrintWithColor(synth, "Invalid Choice. Please restart the story. ", ConsoleColor.Red);
                        StartStory(synth);
                    }
                }
                else
                {
                    PrintWithColor(synth, "Invalid Choice. Please restart the story. ", ConsoleColor.Red);
                    StartStory(synth);
                }
            }

            static void PrintWithColor(SpeechSynthesizer synth, string message, ConsoleColor color)
            {
                Console.ForegroundColor = color;
                synth.Speak(message);
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
