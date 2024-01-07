using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using UnityEngine;

namespace Nesco.EPP
{
    /// <summary>
    /// A static utility class providing extended functionality for interacting with Unity's PlayerPrefs.
    /// Allows storing and retrieving various data types, including primitive types, vectors, quaternions,
    /// and generic objects, using PlayerPrefs. Serialization and deserialization are handled through
    /// Newtonsoft.Json.JsonConvert for generic object storage.
    /// </summary>
    public class ExtendedPlayerPrefs : PlayerPrefs
    {
        /// <summary>
        /// Removes the given keys from the PlayerPrefs. If a key does not exist, DeleteKeys
        /// has no impact on that specific key, but it will remove any existing keys in the
        /// provided array.
        /// </summary>
        /// <param name="keys"></param>
        public static void DeleteKeys(string[] keys)
        {
            foreach (var key in keys)
            {
                DeleteKey(key);
            }
        }

        /// <summary>
        /// Removes the given keys from the PlayerPrefs. If a key does not exist, DeleteKeys
        /// has no impact on that specific key, but it will remove any existing keys in the
        /// provided array.
        /// </summary>
        /// <param name="keys"></param>
        public static void DeleteKeys(List<string> keys)
        {
            foreach (var key in keys)
            {
                DeleteKey(key);
            }
        }

        #region for boolean

        /// <summary>
        /// Retrieves a boolean value from the PlayerPrefs associated with the specified key. If the key exists
        /// </summary>
        /// /// <param name="key">The key associated with the boolean value in PlayerPrefs.</param>
        /// <returns>
        /// A boolean value retrieved from PlayerPrefs or the default boolean value if the key does not exist.
        /// </returns>
        public static bool GetBool(string key)
        {
            if (HasKey(key))
                return GetString(key).ToLower().Contains("t") ? true : false;
            return default(bool);
        }

        /// <summary>
        /// Retrieves a boolean value from the PlayerPrefs associated with the specified key. If the key exists
        /// </summary>
        /// /// <param name="key">The key associated with the boolean value in PlayerPrefs.</param>
        /// <returns>
        /// A boolean value retrieved from PlayerPrefs or the desired boolean value if the key does not exist.
        /// </returns>
        public static bool GetBool(string key, bool defaultValue)
        {
            if (HasKey(key))
                return GetString(key).ToLower().Contains("t") ? true : false;
            return defaultValue;
        }

        /// <summary>
        /// Sets a boolean value in the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate with the boolean value in PlayerPrefs.</param>
        /// <param name="value">The boolean value to be stored in PlayerPrefs.</param>
        public static void SetBool(string key, bool value)
        {
            SetString(key, value.ToString()[0].ToString());
        }
        #endregion

        #region for char

        /// <summary>
        /// Retrieves a character value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the character value in PlayerPrefs.</param>
        /// <returns>
        /// A character value retrieved from PlayerPrefs or if the key does not exist, the method returns the default(char) value.
        /// </returns>
        public static char GetChar(string key)
        {
            if (HasKey(key))
                return GetString(key)[0];
            return default(char);
        }

        /// <summary>
        /// Retrieves a character value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the character value in PlayerPrefs.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist.</param>
        /// <returns>
        /// A character value retrieved from PlayerPrefs or if the key does not exist, the method returns the default(char) value.
        /// </returns>
        public static char GetChar(string key, char defaultValue)
        {
            if (HasKey(key))
                return GetString(key)[0];
            return defaultValue;
        }

        /// <summary>
        /// Sets a character value in the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate with the character value in PlayerPrefs.</param>
        /// <param name="value">The character value to be stored in PlayerPrefs.</param>
        public static void SetChar(string key, char value)
        {
            SetString(key, value.ToString());
        }
        #endregion

        #region for Color

        /// <summary>
        /// Retrieves a Color value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Color value in PlayerPrefs.</param>
        /// <returns>
        /// A Color value retrieved from PlayerPrefs or if the key does not exist, the method returns the default(Color) value.
        /// </returns>
        public static Color GetColor(string key)
        {
            if (HasKey(key))
                return StringToColor(GetString(key));
            return default(Color);
        }

        /// <summary>
        /// Retrieves a Color value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Color value in PlayerPrefs.</param>
        /// <param name="defaultColor">The default Color value to return if the key does not exist.</param>
        /// <returns>
        /// A Color value retrieved from PlayerPrefs or the specified default Color value
        /// </returns>
        public static Color GetColor(string key, Color defaultColor)
        {
            if (HasKey(key))
                return StringToColor(GetString(key));
            return defaultColor;
        }

        /// <summary>
        /// Sets a Color value in the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate with the Color value in PlayerPrefs.</param>
        /// <param name="color">The Color value to be stored in PlayerPrefs.</param>
        public static void SetColor(string key, Color color)
        {
            SetString(key, ColorToString(color));
        }
        #endregion

        #region for double

        /// <summary>
        /// Retrieves a double value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the double value in PlayerPrefs.</param>
        /// <returns>
        /// A double-precision floating-point value retrieved from PlayerPrefs or default(double) if the key does not exist.
        /// </returns>
        public static double GetDouble(string key)
        {
            if (HasKey(key))
                return double.Parse(GetString(key));
            return default(double);
        }

        /// <summary>
        /// Retrieves a double value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the double value in PlayerPrefs.</param>
        /// <returns>
        /// A double-precision floating-point value retrieved from PlayerPrefs or defaultValue if the key does not exist.
        /// </returns>
        public static double GetDouble(string key, double defaultValue)
        {
            if (HasKey(key))
                return double.Parse(GetString(key));
            return defaultValue;
        }

        /// <summary>
        /// Sets a double-precision floating-point value in the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate with the double value in PlayerPrefs.</param>
        /// <param name="value">The double value to be stored in PlayerPrefs.</param>
        public static void SetDouble(string key, double value)
        {
            SetString(key, value.ToString());
        }
        #endregion

        #region for Vector2

        /// <summary>
        /// Retrieves a Vector2 value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Vector2 value in PlayerPrefs.</param>
        /// <returns>
        /// A Vector2 value retrieved from PlayerPrefs or the specified default(Vector2) value
        /// if the key does not exist.
        /// </returns>
        public static Vector2 GetVector2(string key)
        {
            if (HasKey(key))
                return StringToVector2(GetString(key));
            return default(Vector2);
        }

        /// <summary>
        /// Retrieves a Vector2 value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Vector2 value in PlayerPrefs.</param>
        /// <param name="defaultValue">The default Vector2 value to return if the key does not exist.</param>
        /// <returns>
        /// A Vector2 value retrieved from PlayerPrefs or the specified defaultValue value
        /// if the key does not exist.
        /// </returns>
        public static Vector2 GetVector2(string key, Vector2 defaultValue)
        {
            if (HasKey(key))
                return StringToVector2(GetString(key));
            return defaultValue;
        }

        /// <summary>
        /// Sets a Vector2 value in the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate with the Vector2 value in PlayerPrefs.</param>
        /// <param name="value">The Vector2 value to be stored in PlayerPrefs.</param>
        public static void SetVector2(string key, Vector2 value)
        {
            SetString(key, $"{value.x}/{value.y}");
        }
        #endregion

        #region for Vector2Int

        /// <summary>
        /// Retrieves a Vector2Int value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Vector2Int value in PlayerPrefs.</param>
        /// <returns>
        /// A Vector2Int value retrieved from PlayerPrefs or the default(Vector2Int) value
        /// if the key does not exist.
        /// </returns>
        public static Vector2Int GetVector2Int(string key)
        {
            if (HasKey(key))
                return StringToVector2Int(GetString(key));
            return default(Vector2Int);
        }

        /// <summary>
        /// Retrieves a Vector2Int value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Vector2Int value in PlayerPrefs.</param>
        /// <param name="defaultValue">The default Vector2Int value to return if the key does not exist.</param>
        /// <returns>
        /// A Vector2Int value retrieved from PlayerPrefs or the specified defaultValue value
        /// if the key does not exist.
        /// </returns>
        public static Vector2Int GetVector2Int(string key, Vector2Int defaultValue)
        {
            if (HasKey(key))
                return StringToVector2Int(GetString(key));
            return defaultValue;
        }

        /// <summary>
        /// Sets a Vector2Int value in the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate with the Vector2Int value in PlayerPrefs.</param>
        /// <param name="value">The Vector2Int value to be stored in PlayerPrefs.</param>
        public static void SetVector2Int(string key, Vector2Int value)
        {
            SetString(key, $"{value.x}/{value.y}");
        }
        #endregion

        #region for Vector3

        /// <summary>
        /// Retrieves a Vector3 value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Vector3 value in PlayerPrefs.</param>
        /// <returns>
        /// A Vector3 value retrieved from PlayerPrefs or the default default(Vector3)
        /// if the key does not exist.
        /// </returns>
        public static Vector3 GetVector3(string key)
        {
            if (HasKey(key))
                return StringToVector3(GetString(key));
            return default(Vector3);
        }

        /// <summary>
        /// Retrieves a Vector3 value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Vector3 value in PlayerPrefs.</param>
        /// <param name="defaultValue">The default Vector3 value to return if the key does not exist.</param>
        /// <returns>
        /// A Vector3 value retrieved from PlayerPrefs or the defaultValue value
        /// if the key does not exist.
        /// </returns>
        public static Vector3 GetVector3(string key, Vector3 defaultValue)
        {
            if (HasKey(key))
                return StringToVector3(GetString(key));
            return defaultValue;
        }

        /// <summary>
        /// Sets a Vector3 value in the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate with the Vector3 value in PlayerPrefs.</param>
        /// <param name="value">The Vector3 value to be stored in PlayerPrefs.</param>
        public static void SetVector3(string key, Vector3 value)
        {
            SetString(key, $"{value.x}/{value.y}/{value.z}");
        }
        #endregion

        #region for Vector3Int

        /// <summary>
        /// Retrieves a Vector3Int value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Vector3Int value in PlayerPrefs.</param>
        /// <returns>
        /// A Vector3Int value retrieved from PlayerPrefs or the default(Vector3Int)
        /// if the key does not exist.
        /// </returns>
        public static Vector3Int GetVector3Int(string key)
        {
            if (HasKey(key))
                return StringToVector3Int(GetString(key));
            return default(Vector3Int);
        }

        /// <summary>
        /// Retrieves a Vector3Int value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Vector3Int value in PlayerPrefs.</param>
        /// <param name="defaultValue">The default Vector3Int value to return if the key does not exist.</param>
        /// <returns>
        /// A Vector3Int value retrieved from PlayerPrefs or the defaultValue value
        /// if the key does not exist.
        /// </returns>
        public static Vector3Int GetVector3Int(string key, Vector3Int defaultValue)
        {
            if (HasKey(key))
                return StringToVector3Int(GetString(key));
            return defaultValue;
        }

        /// <summary>
        /// Sets a Vector3Int value in the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate with the Vector3Int value in PlayerPrefs.</param>
        /// <param name="value">The Vector3Int value to be stored in PlayerPrefs.</param>
        public static void SetVector3Int(string key, Vector3Int value)
        {
            SetString(key, $"{value.x}/{value.y}/{value.z}");
        }
        #endregion

        #region for Vector4

        /// <summary>
        /// Retrieves a Vector4 value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Vector4 value in PlayerPrefs.</param>
        /// <returns>
        /// A Vector4 value retrieved from PlayerPrefs or the default(Vector4)
        /// if the key does not exist.
        /// </returns>
        public static Vector4 GetVector4(string key)
        {
            if (HasKey(key))
                return StringToVector4(GetString(key));
            return default(Vector4);
        }

        /// <summary>
        /// Retrieves a Vector4 value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Vector4 value in PlayerPrefs.</param>
        /// <param name="defaultValue">The default Vector4 value to return if the key does not exist.</param>
        /// <returns>
        /// A Vector4 value retrieved from PlayerPrefs or the defaultValue value
        /// if the key does not exist.
        /// </returns>
        public static Vector4 GetVector4(string key, Vector4 defaultValue)
        {
            if (HasKey(key))
                return StringToVector4(GetString(key));
            return defaultValue;
        }

        /// <summary>
        /// Sets a Vector4 value in the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate with the Vector4 value in PlayerPrefs.</param>
        /// <param name="value">The Vector4 value to be stored in PlayerPrefs.</param>
        public static void SetVector4(string key, Vector4 value)
        {
            SetString(key, $"{value.x}/{value.y}/{value.z}/{value.w}");
        }
        #endregion

        #region for Quaternion

        /// <summary>
        /// Retrieves a Quaternion value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Quaternion value in PlayerPrefs.</param>
        /// <returns>
        /// A Quaternion value retrieved from PlayerPrefs or the default(Quaternion)
        /// if the key does not exist.
        /// </returns>
        public static Quaternion GetQuaternion(string key)
        {
            if (HasKey(key))
                return StringToQuaternion(GetString(key));
            return default(Quaternion);
        }

        /// <summary>
        /// Retrieves a Quaternion value from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key associated with the Quaternion value in PlayerPrefs.</param>
        /// <param name="defaultValue">The default Quaternion value to return if the key does not exist.</param>
        /// <returns>
        /// A Quaternion value retrieved from PlayerPrefs or the defaultValue value
        /// if the key does not exist.
        /// </returns>
        public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
        {
            if (HasKey(key))
                return StringToQuaternion(GetString(key));
            return defaultValue;
        }

        /// <summary>
        /// Sets a Quaternion value in the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate with the Quaternion value in PlayerPrefs.</param>
        /// <param name="value">The Quaternion value to be stored in PlayerPrefs.</param>
        public static void SetQuaternion(string key, Quaternion value)
        {
            SetString(key, $"{value.x}/{value.y}/{value.z}/{value.w}");
        }
        #endregion

        #region for Generic

        /// <summary>
        /// Retrieves a generic object of type T from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <typeparam name="T">The type of the object to retrieve from PlayerPrefs.</typeparam>
        /// <param name="key">The key associated with the object value in PlayerPrefs.</param>
        /// <returns>
        /// An object of type T retrieved from PlayerPrefs or the default(T)
        /// if the key does not exist.
        /// </returns>
        public static T GetGeneric<T>(string key)
        {
            if (HasKey(key))
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(GetString(key));
            }
            return default(T);
        }

        /// <summary>
        /// Retrieves a generic object of type T from the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <typeparam name="T">The type of the object to retrieve from PlayerPrefs.</typeparam>
        /// <param name="key">The key associated with the object value in PlayerPrefs.</param>
        /// <param name="defaultValue">The default value to return if the key does not exist.</param>
        /// <returns>
        /// An object of type T retrieved from PlayerPrefs or the defaultValue
        /// if the key does not exist.
        /// </returns>
        public static T GetGeneric<T>(string key, T defaultValue)
        {
            if (HasKey(key))
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(GetString(key));
            }
            return defaultValue;
        }

        /// <summary>
        /// Sets a generic object of type T in the PlayerPrefs associated with the specified key.
        /// </summary>
        /// <typeparam name="T">The type of the object to store in PlayerPrefs.</typeparam>
        /// <param name="key">The key to associate with the object value in PlayerPrefs.</param>
        /// <param name="value">The object of type T to be stored in PlayerPrefs.</param>
        public static void SetGeneric<T>(string key, T value)
        {
            try
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(value);
                SetString(key, data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

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