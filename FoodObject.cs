using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SOFT152SteeringLibrary;

namespace SOFT152Steering
{
    class FoodObject
    {
        /// <summary>
        /// Current postion of the nest
        /// </summary>
        private SOFT152Vector foodPosition;

        private int foodValue {get;set;}


        public FoodObject(SOFT152Vector position)
        {
            foodPosition = new SOFT152Vector(position.X, position.Y);

        }

        public FoodObject(SOFT152Vector position, int value)
        {
            foodPosition = new SOFT152Vector(position.X, position.Y);

            foodValue = 100;

        }
        public SOFT152Vector FoodPosition
        {
            set
            {
                foodPosition = value;
            }

            get
            {
                return foodPosition;
            }
        }

    }
}
