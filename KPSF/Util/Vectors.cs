using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace KPSF.KPSFlib.Util
{
    public static class Vectors
    {
        public static Vector3 TupleToV3(Tuple<double, double, double> a)
        {
            return new Vector3((float)a.Item1, (float)a.Item2, (float)a.Item3);
        }

        public static Vector3 TupleToV3(Tuple<float, float, float> a)
        {
            return new Vector3(a.Item1, a.Item2, a.Item3);
        }

        public static Tuple<double, double, double> V3ToTuple(Vector3 a)
        {
            return new Tuple<double, double, double>(a.x, a.y, a.z);
        }

    }
}
