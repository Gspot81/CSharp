﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
   public class StoryTeller
    {
        public string TellStory(string nameOfChild, int ageOfChild, bool willBeScary)
        {
            if (ageOfChild < 5 && willBeScary)      
                throw new InvalidOperationException();
            string prefix = "";
            if (ageOfChild < 7)
                prefix += $"Lyssna nu {nameOfChild}. Det var en gång en prinsessa ";
            else
                prefix += $"Hallå {nameOfChild}! Det var en gång en kille ";

            string suffix = "";
            if (!willBeScary)
                suffix += $"som tyckte om att dansa.";
            else
                suffix += $"som egentligen var en varulv.";

            return prefix + suffix;
          
        }
    }
}

