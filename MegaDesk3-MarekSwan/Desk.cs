using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk3_MarekSwan
{
    public struct Desk
    {
        //properties
        public float Width;
        public float Depth;
        public int NumOfDraws;
        public float SurfaceArea;
        public SurfaceMaterials GetSurface { get; set; }
        public float SurfaceValue;

        public enum SurfaceMaterials
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }

        //method for sending Width and Depth
        public Tuple<float, float> GetMeasurements()
        {
            var Measurements = Tuple.Create(Width, Depth);
            return Measurements;
        }

    }
}
