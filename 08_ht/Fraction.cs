using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ht
{
    struct Vector3d
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3d MultByNum(double num)
        {
            return new Vector3d(X * num, Y * num, Z * num);
        }

        public Vector3d Add(Vector3d other)
        {
            return new Vector3d(X + other.X, Y + other.Y, Z + other.Z);
        }

        public Vector3d Sub(Vector3d other)
        {
            return new Vector3d(X - other.X, Y - other.Y, Z - other.Z);
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
