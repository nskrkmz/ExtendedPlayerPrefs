using System;
using UnityEngine;

namespace Nesco.EPP
{
    public partial class ExtendedPlayerPrefs
    {
        private static Color StringToColor(string colorCode)
        {
            Color color = Color.clear;
            string[] components = colorCode.Split('/');

            if (components.Length == 4)
            {
                bool state = float.TryParse(components[0], out color.r) &&
                float.TryParse(components[1], out color.g) &&
                float.TryParse(components[2], out color.b) &&
                float.TryParse(components[3], out color.a);

                if (!state)
                    throw new FormatException();
            }
            else
                throw new FormatException();

            return color;
        }

        private static Vector2 StringToVector2(string value)
        {
            Vector2 v2 = new();
            string[] components = value.Split('/');

            if (components.Length == 2)
            {
                v2.x = StringToFloat(components[0]);
                v2.y = StringToFloat(components[1]);
            }
            else
                throw new FormatException();

            return v2;
        }
        private static float StringToFloat(string value)
        {
            return float.Parse(value);
        }
        private static Vector2Int StringToVector2Int(string value)
        {
            Vector2Int v2 = new();
            string[] components = value.Split('/');

            if (components.Length == 2)
            {
                v2.x = StringToInt(components[0]);
                v2.y = StringToInt(components[1]);
            }
            else
                throw new FormatException();

            return v2;
        }
        private static Vector3 StringToVector3(string value)
        {
            Vector3 v3 = new();
            string[] components = value.Split('/');

            if (components.Length == 3)
            {
                v3.x = StringToFloat(components[0]);
                v3.y = StringToFloat(components[1]);
                v3.z = StringToFloat(components[2]);
            }
            else
                throw new FormatException();

            return v3;
        }
        private static Vector3Int StringToVector3Int(string value)
        {
            Vector3Int v3 = new();
            string[] components = value.Split('/');

            if (components.Length == 3)
            {
                v3.x = StringToInt(components[0]);
                v3.y = StringToInt(components[1]);
                v3.z = StringToInt(components[2]);
            }
            else
                throw new FormatException();

            return v3;
        }
        private static Quaternion StringToQuaternion(string value)
        {
            Quaternion quaternion = new();
            string[] components = value.Split('/');

            if (components.Length == 4)
            {
                quaternion.x = StringToFloat(components[0]);
                quaternion.y = StringToFloat(components[1]);
                quaternion.z = StringToFloat(components[2]);
                quaternion.w = StringToFloat(components[3]);
            }
            else
                throw new FormatException();

            return quaternion;
        }

        private static Vector4 StringToVector4(string value)
        {
            Vector4 v4 = new();
            string[] components = value.Split('/');

            if (components.Length == 4)
            {
                v4.x = StringToFloat(components[0]);
                v4.y = StringToFloat(components[1]);
                v4.z = StringToFloat(components[2]);
                v4.w = StringToFloat(components[3]);
            }
            else
                throw new FormatException();

            return v4;
        }

        private static int StringToInt(string value)
        {
            return Int32.Parse(value);
        }

        private static string ColorToString(Color color)
        {
            return $"{color.r}/{color.g}/{color.b}/{color.a}";
        }
    }
}

