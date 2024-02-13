using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorApp
{
    public class Vector2
    {
        public float x;
        public float y;

        public Vector2(float x1, float y1)
        {
            x = x1;
            y = y1;
        }

        public Vector2(double x1, double y1)
        {
            x = (float)x1;
            y = (float)y1;
        }


        public double resulant()
        {
            return Convert.ToDouble(x + y);
        }

        public double resulant(double pow)
        {
            return Math.Pow(Convert.ToDouble(x), pow) + Math.Pow(Convert.ToDouble(y), pow);
        }

        public Vector2 normalize()
        {
            double mag = magnitude();

            return new Vector2(x / mag, y / mag);
        }

        public double dot(Vector2 vec2)
        {
            return x * vec2.x + y * vec2.y;
        }

        public double cross(Vector2 vec2)
        {
            return (x * vec2.y) - (y * vec2.x);
        }

        public double angleBetween(Vector2 vec2)
        {
            Vector2 normA = this.normalize();
            Vector2 normB = vec2.normalize();

            return Math.Acos(normA.dot(normB)) * 180 / Math.PI;
        }

        public double magnitude()
        {
            return Math.Sqrt(Convert.ToDouble(resulant(2)));
        }

        public double direction()
        {
            return Math.Atan(Convert.ToDouble(y / x)) * 180 / Math.PI;
        }

        public Vector2 projection(Vector2 vecB)
        {
            return (vecB * this) / (vecB * vecB) * vecB;
        }

        public Vector2 negate()
        {
            return new Vector2(-x, -y);
        }

        public string print()
        {
            return "(" + x + ", " + y + ")";
        }

        public static Vector2 operator +(Vector2 veca, Vector2 vecb)
        {
            return new Vector2(veca.x + vecb.x, veca.y + vecb.y);
        }
        public static Vector2 operator -(Vector2 veca, Vector2 vecb)
        {
            return new Vector2(veca.x - vecb.x, veca.y - vecb.y);
        }
        public static Vector2 operator *(Vector2 veca, Vector2 vecb)
        {
            return new Vector2(veca.x * vecb.x, veca.y * vecb.y);
        }
        public static Vector2 operator /(Vector2 veca, Vector2 vecb)
        {
            return new Vector2(veca.x / vecb.x, veca.y / vecb.y);
        }
        public static Vector2 operator ^(Vector2 veca, double pow)
        {
            return new Vector2((float)(Math.Pow(veca.x, pow)), (float)(Math.Pow(veca.y, pow)));
        }
    }
}
