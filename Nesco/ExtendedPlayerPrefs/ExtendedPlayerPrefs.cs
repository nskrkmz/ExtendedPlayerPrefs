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
        private static bool IsKeyFormatValid(string key)
        {
            return regex.IsMatch(key);
        }
    }
}

