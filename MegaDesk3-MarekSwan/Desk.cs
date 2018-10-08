using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk3_MarekSwan
{
    class Desk
    {
        //properties
        private float Width { get; set; }
        private float Depth { get; set; }
        private int NumOfDraws { get; set; }
        private float SurfaceArea { get; }

        enum SurfaceMaterials
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }

        //default constructor
        Desk(float Width, float Depth, int NumOfDraws)
        {
            SurfaceArea = Width * Depth;
        }

        //method for sending Width and Depth
        public Tuple<float, float> GetMeasurements()
        {
            var Measurements = Tuple.Create(Width, Depth);
            return Measurements;
        }

    }
}
