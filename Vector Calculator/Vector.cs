using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        //Functional
        public float GetMagnitude()
        {
            return (MathF.Sqrt((this.x * this.x) + (this.y * this.y) + (this.z *this.z) ));
        }

        // Functional
        public float GetDirection()
        {
            double tangentVal = this.y / this.x;
            double atanVal = Math.Atan(tangentVal);
            float returnVal = (float)atanVal;
            return returnVal;
        }

        //Functional
        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        //Functional
        public static Vector Negate(Vector v)
        {
            return new Vector(-v.x, -v.y, -v.z);
        }

        //Functional
        public static Vector Subtract(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        //Functional
        public static Vector Scale(Vector v, float scaleFactor)
        {
            return new Vector(v.x * scaleFactor, v.y * scaleFactor, v.z * scaleFactor);
        }

        public static Vector Normalize(Vector v)
        {
            float divideVal = v.GetMagnitude();
            return new Vector(v.x / divideVal, v.y / divideVal, v.z / divideVal);
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            float returnVal = (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
            return returnVal;
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            float xVal = (v1.y * v2.z) - (v1.z * v2.y);
            float yVal = (v1.z * v2.x) - (v1.x * v2.z);
            float zVal = (v1.x * v2.y) - (v1.y * v2.x);
            return new Vector(xVal, yVal, zVal);
        }

        public static float AngleBetween(Vector v1, Vector v2)
        {
            float magA = v1.GetMagnitude();
            float magB = v2.GetMagnitude();
            float interiorMath = Vector.DotProduct(v1, v2) / (magA * magB);
            float theta = MathF.Acos(interiorMath);
            return theta;
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            float scaleFactor = Vector.DotProduct(v1, v2) / (v2.GetMagnitude() * v2.GetMagnitude());
            return Vector.Scale(v2, scaleFactor);
        }
    }
}
