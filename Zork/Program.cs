using System;
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
            //defining nodes
            Area a = new Area("Entrance", "it looks dark and spooky, are you sure you should be here?");
            Area b = new Area("Dickbutt palace", "are you really sure you should be HERE?");
            Area c = new Area("The basement", "it's locked and damp");
            Area d = new Area("The crypt", "The tombs have already been raided :(");

            //defining edges
            a.AddArea(c, Directions.West);
            c.AddArea(a, Directions.East);
            c.AddArea(d, Directions.West);
            d.AddArea(c, Directions.East);
            a.AddArea(b, Directions.North);
            b.AddArea(a, Directions.South);

            //starting area
            Area currentArea = a;

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
