﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VarukorgLib
{
    [TestClass]
    public class Kund
    {
        public string FirstName;
        public string LastName;

        public Kund(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
