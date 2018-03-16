﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    public enum Directions
    {
        West,
        North,
        South,
        East
    }

    public class Area
    {
        //something to hold connected nodes/areas
        public Dictionary<Directions, Area> neighbors = new Dictionary<Directions, Area>();
        //name of area
        public string name;
        //description of area
        public string description;

        //construtor
        public Area(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        //method to add an area to a specific direction
        public void AddArea(Area other, Directions dir)
        {
            neighbors.Add(dir, other);

            //other.neighbors.Add(, this);
        }

        //method that returns connected area in specific direction
    }
}
