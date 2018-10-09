using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk3_MarekSwan
{
    class DeskQuote
    {
        public bool RushOrder { get; set; }
        public int RushValue { get; set; }
        public string CustName { get; set; }
        public DateTime QuoteDate { get; set; }
        public float QuotePrice { get; set; }


        //Default Constructor
        DeskQuote()
        {

        }

        //This is a temp peice of code, a parent child realtionship is required (maybe)
        Desk Desk1 = new Desk(20, 34, 1);

        //trying to figure out enums

        public int CalcSurface(int SurfaceValue)
        {
            switch (SurfaceValue)
            {
                case 0:
                    return 200;
                case 1:
                    return 100;
                case 2:
                    return 50;
                case 3:
                    return 125;
                default:
                    return 0;

            }

        }


        public int CalcRush(int RushValue, float SurfaceArea)
        {
            if (SurfaceArea < 1000)
            {
                switch (RushValue)
                {
                    case 3:
                        return 60;
                    case 5:
                        return 40;
                    case 7:
                        return 30;

                }
            }
            else if (SurfaceArea >= 1000)
            {
                switch (RushValue)
                {
                    case 3:
                        return 70;
                    case 5:
                        return 50;
                    case 7:
                        return 30;

                }
            }
            else
            {
                switch (RushValue)
                {
                    case 3:
                        return 80;
                    case 5:
                        return 60;
                    case 7:
                        return 40;

                }
            }
            return 0;
        }

        public int CalcQuote(int Draws, int Surface, int SurfaceArea, bool RushOrder)
        {
            int TempQuote = 200 + (50 * Draws);

            if (SurfaceArea > 1000)
            {
                int ExtraArea = SurfaceArea - 1000;
                TempQuote += ExtraArea;
            }

            if(RushOrder == true)
            {
                TempQuote += CalcRush(this.RushValue, SurfaceArea);
            }

            return TempQuote;
        }









    }
}
