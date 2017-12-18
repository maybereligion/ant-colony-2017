using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SOFT152SteeringLibrary;

namespace SOFT152Steering
{
    class NestObject
    {

        /// <summary>
        /// Current postion of the nest
        /// </summary>
        private SOFT152Vector nestPosition;

        public NestObject(SOFT152Vector position)
        {
            nestPosition = new SOFT152Vector(position.X, position.Y);

           
        }

        public SOFT152Vector NestPosition
        {
            set
            {
                nestPosition = value;
            }

            get
            {
                return nestPosition;
            }
        }

    }
}
