﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum Color
    {
        Red,
        Black
    }

    public struct Coordinates
    {
        public int X;
        public int Y;
    }

    public class Checker
    {
        public Color Color { get; private set; }

        public bool King { get; set; }

        public Coordinates Coords;

        public Checker(Color color, int x, int y)
        {
            this.Color = color;
            Coords.X = x;
            Coords.Y = y;
        }


    }
}
