﻿using System;

namespace S1_Ex3
{
    public class Person
    {
        public string Name
        {
            get; set;
        }
        public void Introduce()
        {
            Console.WriteLine("Hello I am " + Name);
        }
    }
}