using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint1
{
    public class FigureAngles
    {
        public static int Angles { set; get; } = 3;
        public FigureAngles()
        {
        }
        public static void SetAngles(int angles)
        {
            if (angles < 3) Angles = 3;
            else Angles = angles;
        }
        public static int GetAngles()
        {
            return Angles;
        }
    }
}
