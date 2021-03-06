﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewRegTest
{
    public class EmployeeConverter
    {
        public string Convert(string input)
        {
            //@"""Mattias Asplund"" 46 35000.00 070-6186120";
            //"Asplund, Mattias (Lön: 35000.00) Telefon: 070 - 6186120 Föddelseår: 1971";

            string pattern = @"\""?([^\""]*) (\w+)\""? (\d{2}) (\d{5}).(\d{2}) (\d{3})-(\d{7})";
            int year = DateTime.Now.AddYears(-46).Year;
            Match m = Regex.Match(input, pattern);
            return m.Groups[2].Value + 
                            ", " + 
                            m.Groups[1] + 
                            " (Lön: " +
                            m.Groups[4].Value + "." +
                            m.Groups[5].Value +")" + 
                            " Telefon: " + 
                            m.Groups[6] + " - " + 
                            m.Groups[7] + 
                            " Föddelseår: " 
                            + year;
        }
    }
}
