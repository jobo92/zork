using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork.Tests
{
    [TestClass()]
    public class MapTests
    {
        // Looks for islands (areas with no connections) in the map
        [TestMethod()]
        public void MapIslandTest()
        {
            Map map = new Map();
            foreach (Area a in map.areas)
            {
                if (a.neighbors.Count == 0)
                {
                    Assert.Fail();
                }
            }
        }
    }
}