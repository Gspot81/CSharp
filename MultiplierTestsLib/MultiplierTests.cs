﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestsLib
{
    [TestClass]
    public class MultiplierTests
    {
        [TestMethod]
        public void Simple()
        {
            //Arrange
            MultiplierLib.Mulitplier myMultiplier = new MultiplierLib.Mulitplier();
            //Act
            var actual = myMultiplier.Simple(20, 20);
            //Assert
            Assert.AreEqual(400, actual);
        }
        [TestMethod]
        public void UsingFor()
        {
            //Arrange
            MultiplierLib.Mulitplier myMultiplier = new MultiplierLib.Mulitplier();
            //Act
            var actual = myMultiplier.UsingFor(20, 20);
            //Assert
            Assert.AreEqual(400, actual);
        }
        [TestMethod]
        public void While()
        {
            //Arrange
            MultiplierLib.Mulitplier myMultiplier = new MultiplierLib.Mulitplier();
            //Act
            var actual = myMultiplier.While(20, 20);
            //Assert
            Assert.AreEqual(400, actual);
        }
    }
}
