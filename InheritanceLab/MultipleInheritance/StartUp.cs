﻿using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Puppy pup = new Puppy();
            pup.Eat();
            pup.Bark();
            pup.Weep();
        }
    }
}
