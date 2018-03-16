using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    public class Map
    {
        // player starting position
        public Area startingPosition;
        public List<Area> areas;

        public Map()
        {
            //defining nodes
            Area a = new Area("Entrance", "it looks dark and spooky, are you sure you should be here?");
            Area b = new Area("Dickbutt palace", "are you really sure you should be HERE?");
            Area c = new Area("The basement", "it's locked and damp");
            Area d = new Area("The crypt", "The tombs have already been raided :(");
            //Area e = new Area("The crypt", "The tombs have already been raided :(");

            //adding areas to list
            areas = new List<Area>();
            areas.Add(a);
            areas.Add(b);
            areas.Add(c);
            areas.Add(d);
            //areas.Add(e);

            //defining edges
            a.AddArea(c, Directions.West);
            c.AddArea(a, Directions.East);
            c.AddArea(d, Directions.West);
            d.AddArea(c, Directions.East);
            a.AddArea(b, Directions.North);
            b.AddArea(a, Directions.South);

            startingPosition = a;
        }
    }
}
