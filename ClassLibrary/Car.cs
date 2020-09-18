﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Method for getting the price of a ticket for the car
        /// </summary>
        /// <returns>returns the double 240.00</returns>
        public override double Price()
        {
            return 240.00;
        }

        /// <summary>
        /// Method for getting the type of vehicle
        /// </summary>
        /// <returns>returns the string "Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
