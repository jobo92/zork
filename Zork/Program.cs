﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a map
            Map map = new Map();

            //starting area
            Area currentArea = map.startingPosition;

            //gameplay loop
            while (true)
            {
                //let's print where we are
                Console.WriteLine("You are in " + currentArea.name);

                //read input
                string command = Console.ReadLine();
                //split it to separate, e.g. "go east" into {"go", "east"}
                string[] inputs = command.Split(' ');
                switch (inputs[0])
                {
                    //the "go" command is given
                    case "go":
                    case "Go":
                        switch (inputs[1])
                        {
                            case "east":
                                GoToDirection(Directions.East, ref currentArea);
                                break;
                            case "west":
                                GoToDirection(Directions.West, ref currentArea);
                                break;
                            case "south":
                                GoToDirection(Directions.South, ref currentArea);
                                break;
                            case "north":
                                GoToDirection(Directions.North, ref currentArea);
                                break;
                        }
                        break;

                    case "examine":
                        //give some info about current area
                        Console.WriteLine(currentArea.description);
                        Console.WriteLine();

                        //for each key in neighbors
                        foreach (Directions dir in currentArea.neighbors.Keys)
                        {
                            Console.WriteLine("To the " + dir.ToString().ToLower() + " there is a " + currentArea.neighbors[dir].name);
                        }
                        break;

                    case "quit":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }

        public static void GoToDirection(Directions dir, ref Area currentArea)
        {
            if (currentArea.neighbors.ContainsKey(dir))
                currentArea = currentArea.neighbors[dir];
            else Console.WriteLine("There's nothing there");
        }
    }
}
