﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Model
{
    public class RectangleItem
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public RectangleItem(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;

        }

    }
}
