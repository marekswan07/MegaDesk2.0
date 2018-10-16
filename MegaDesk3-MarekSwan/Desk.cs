using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk3_MarekSwan
{
    public class Desk
    {
        //properties
        public float Width { get; set; }
        public float Depth { get; set; }
        public int NumOfDraws { get; set; }
        public float SurfaceArea { get; }
        public SurfaceMaterials GetSurface { get; set; }
        public float SurfaceValue { get; set; }

        public enum SurfaceMaterials
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }


        //default constructor
        public Desk(float Width, float Depth, int NumOfDraws)
        {
            this.Width = Width;
            this.Depth = Depth;
            SurfaceArea = Width * Depth;
            this.NumOfDraws = NumOfDraws;
        }

        //method for sending Width and Depth
        public Tuple<float, float> GetMeasurements()
        {
            var Measurements = Tuple.Create(Width, Depth);
            return Measurements;
        }

    }
}
