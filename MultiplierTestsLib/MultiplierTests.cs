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
    }
}
