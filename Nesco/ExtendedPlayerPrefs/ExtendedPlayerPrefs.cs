using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using UnityEngine;

namespace Nesco.EPP
{
    public class ExtendedPlayerPrefs : PlayerPrefs
    {
        private const string KEY_PATTERN = "^[a-zA-Z0-9]+$";
        private static Regex regex = new(KEY_PATTERN);
        
        public static void DeleteKeys(string[] keys)
        {
            foreach (var key in keys)
            {
                if (IsKeyFormatValid(key))
                    DeleteKey(key);
                else
                    throw new ArgumentException($"Invalid key: {nameof(key)}");
            }
        }

        #region for boolean
        public static bool GetBool(string key)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return GetString(key).ToLower().Contains("t") ? true : false;
            return false;
        }
        public static bool GetBool(string key, bool defaultValue)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return GetString(key).ToLower().Contains("t") ? true : false;
            return defaultValue;
        }
        public static void SetBool(string key, bool value)
        {
            if (IsKeyFormatValid(key))
                SetString(key, value.ToString()[0].ToString());
        }
        #endregion

        #region for char
        public static char GetChar(string key)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return GetString(key)[0];
            return ' ';
        }
        public static char GetChar(string key, char defaultValue)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return GetString(key)[0];
            return defaultValue;
        }
        public static void SetChar(string key, char value)
        {
            if (IsKeyFormatValid(key))
                SetString(key, value.ToString());
        }
        #endregion

        #region for Color
        public static Color GetColor(string key)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return StringToColor(GetString(key));
            return Color.white;
        }
        public static Color GetColor(string key, Color defaultColor)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return StringToColor(GetString(key));
            return defaultColor;
        }
        public static void SetColor(string key, Color color)
        {
            if (IsKeyFormatValid(key))
            {
                SetString(key, ColorToString(color));
            }
        }
        #endregion

        #region for double
        public static double GetDouble(string key)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return double.Parse(GetString(key));
            return 0d;
        }
        public static double GetDouble(string key, double defaultValue)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return double.Parse(GetString(key));
            return defaultValue;
        }
        public static void SetDouble(string key, double value)
        {
            if (IsKeyFormatValid(key))
                SetString(key, value.ToString());
        }
        #endregion

        #region for Vector2
        public static Vector2 GetVector2(string key)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return StringToVector2(GetString(key));
            return Vector2.zero;
        }
        public static Vector2 GetVector2(string key, Vector2 defaultValue)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return StringToVector2(GetString(key));
            return defaultValue;
        }
        public static void SetVector2(string key, Vector2 value)
        {
            if (IsKeyFormatValid(key))
                SetString(key, $"{value.x},{value.y}");
        }
        #endregion

        #region for Vector2Int
        public static Vector2Int GetVector2Int(string key)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return StringToVector2Int(GetString(key));
            return Vector2Int.zero;
        }
        public static Vector2Int GetVector2Int(string key, Vector2Int defaultValue)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return StringToVector2Int(GetString(key));
            return defaultValue;
        }
        public static void SetVector2Int(string key, Vector2Int value)
        {
            if (IsKeyFormatValid(key))
                SetString(key, $"{value.x},{value.y}");
        }
        #endregion

        #region for Vector3
        public static Vector3 GetVector3(string key)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return StringToVector3(GetString(key));
            return Vector3.zero;
        }
        public static Vector3 GetVector3(string key, Vector3 defaultValue)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return StringToVector3(GetString(key));
            return defaultValue;
        }
        public static void SetVector3(string key, Vector3 value)
        {
            if (IsKeyFormatValid(key))
                SetString(key, $"{value.x},{value.y},{value.z}");
        }
        #endregion

        #region for Vector3Int
        public static Vector3Int GetVector3Int(string key)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return StringToVector3Int(GetString(key));
            return Vector3Int.zero;
        }
        public static Vector3Int GetVector3Int(string key, Vector3Int defaultValue)
        {
            if (IsKeyFormatValid(key) && HasKey(key))
                return StringToVector3Int(GetString(key));
            return defaultValue;
        }
        public static void SetVector3Int(string key, Vector3Int value)
        {
            if (IsKeyFormatValid(key))
                SetString(key, $"{value.x},{value.y},{value.z}");
        }
        #endregion
        private static bool IsKeyFormatValid(string key)
        {
            return regex.IsMatch(key);
        }

        private static Color StringToColor(string colorCode)
        {
            Color color = Color.clear;
            string[] components = colorCode.Split(',');

            if (components.Length == 4)
            {
                bool state = float.TryParse(components[0], out color.r) &&
                float.TryParse(components[1], out color.g) &&
                float.TryParse(components[2], out color.b) &&
                float.TryParse(components[3], out color.a);

                if(!state)
                    throw new FormatException();
            }
            else
                throw new FormatException();

            return color;
        }

        private static Vector2 StringToVector2(string value)
        {
            Vector2 v2 = new();
            string[] components = value.Split(',');

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
            string[] components = value.Split(',');

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
            string[] components = value.Split(',');

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
            string[] components = value.Split(',');

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
        private static int StringToInt(string value)
        {
            return Int32.Parse(value);
        }


        private static string ColorToString(Color color)
        {
            return $"{color.r},{color.g},{color.b},{color.a}";
        }
    }
}

