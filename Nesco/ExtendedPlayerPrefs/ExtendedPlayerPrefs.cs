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

        private static string ColorToString(Color color)
        {
            return $"{color.r},{color.g},{color.b},{color.a}";
        }
    }
}

