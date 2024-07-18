﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation
{
    internal class Angle
    {
        public int degrees;
        public float minutes;
        public char direction;

        public Angle (int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        public string formatAngle()
        {
            return $"{degrees}°{minutes}' {direction}";
        }
    }
}
