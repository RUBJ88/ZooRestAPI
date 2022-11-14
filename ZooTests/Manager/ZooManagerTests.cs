using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Manager.Tests
{
    [TestClass()]
    public class ZooManagerTests
    {
        private IZoo zgr;

        [TestInitialize]
        public void BeforeEachTest()
        {
            zgr = new ZooManager();

        }
        [TestMethod()]
        public void CreateTest()
        {
            Assert.Fail();
        }

        
        [TestMethod()]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("         ")]
        public void ReadNavn1(String? navn)
        {
            // arrange
            // tom

            // act
            List<ZOO> result = zgr.Read(navn);

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod()]
        [DataRow("giraf")]
        [DataRow("abe")]
        public void ReadNavn2(String navn)
        {
            // arrange
            // tom

            // act
            List<ZOO> result = zgr.Read(navn);

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod()]
        [DataRow("Ulv")]
        public void ReadNavn3(String navn)
        {
            // arrange
            // tom

            // act
            List<ZOO> result = zgr.Read(navn);

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
        }


        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ReadTest1()
        {
            Assert.Fail();
        }
    }
}