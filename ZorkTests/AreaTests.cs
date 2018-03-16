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
    public class AreaTests
    {
        /*
         * We create two areas, we connect them and we check if they are correctly connected
         */
        [DataTestMethod()]
        [DataRow(Directions.West)]
        [DataRow(Directions.East)]
        [DataRow(Directions.North)]
        [DataRow(Directions.South)]
        public void AddAreaTest(Directions dir)
        {
            Area a = new Area("The basement", "it's locked and damp");
            Area b = new Area("The crypt", "The tombs have already been raided :(");

            //defining edges
            a.AddArea(b, dir);

            Assert.AreEqual(a.neighbors[dir], b);
        }
    }
}