﻿using DataStructureProblem.Arrays_Part1;
using System;

namespace DataStructureProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ISolvable problem = new SortColorsProblem();
            problem.Solve();
        }
    }
}
