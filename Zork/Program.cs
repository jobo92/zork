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
            Area a = new Area("A", "");
            Area b = new Area("B", "");
            Area c = new Area("C", "");
            Area d = new Area("D", "");

            //defining edges
            a.AddArea(c, Directions.West);
            c.AddArea(a, Directions.East);
            c.AddArea(d, Directions.West);
            d.AddArea(c, Directions.East);
            a.AddArea(b, Directions.North);
            b.AddArea(a, Directions.South);

            //starting area
            Area currentArea = a;

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

                default:
                    break;
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
