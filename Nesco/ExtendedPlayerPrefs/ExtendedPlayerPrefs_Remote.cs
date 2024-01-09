using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;

namespace Nesco.EPP
{
    public partial class ExtendedPlayerPrefs
    {
        public static RemoteExtendedPlayerPrefs Remote = new RemoteExtendedPlayerPrefs();
    }

    public class RemoteExtendedPlayerPrefs
    {
        #region for Keys
        public void HasKey(IDBConfig dBConfig, IRecord record, string key)
        {

        }
        public void HasKey(IDBConfig dBConfig, IRecord record, string key, Action<bool> callback)
        {

        }
        public void HasKey(IDBConfig dBConfig, IRecord record, string key, Action<List<UnityWebRequest.Result>> callback)
        {

        }
        public async Task<bool> HasKeyAsync(IDBConfig dBConfig, IRecord record, string key)
        {

        }
        public async Task<List<UnityWebRequest.Result>> HasKeyAsync(IDBConfig dBConfig, IRecord record, string key)
        {

        }

        public void DeleteKey(IDBConfig dBConfig, IRecord record, string key)
        {

        }
        public void DeleteKey(IDBConfig dBConfig, IRecord record, string key, Action<bool> callback)
        {

        }
        public void DeleteKey(IDBConfig dBConfig, IRecord record, string key, Action<List<UnityWebRequest.Result>> callback)
        {

        }
        public async Task<bool> DeleteKeyAsync(IDBConfig dBConfig, IRecord record, string key)
        {

        }
        public async Task<List<UnityWebRequest.Result>> DeleteKeyAsync(IDBConfig dBConfig, IRecord record, string key)
        {

        }

        public void DeleteKeys(IDBConfig dBConfig, IRecord record, string[] keys)
        {

        }
        public void DeleteKeys(IDBConfig dBConfig, IRecord record, string[] keys, Action<List<bool>> callback)
        {

        }
        public void DeleteKeys(IDBConfig dBConfig, IRecord record, string[] keys, Action<List<UnityWebRequest.Result>> callback)
        {

        }
        public async Task<List<bool>> DeleteKeysAsync(IDBConfig dBConfig, IRecord record, string[] keys)
        {

        }
        public async Task<List<UnityWebRequest.Result>> DeleteKeysAsync(IDBConfig dBConfig, IRecord record, string[] keys)
        {

        }

        public void DeleteKeys(IDBConfig dBConfig, IRecord record, List<string> keys)
        {

        }
        public void DeleteKeys(IDBConfig dBConfig, IRecord record, List<string> keys, Action<List<bool>> callback)
        {

        }
        public void DeleteKeys(IDBConfig dBConfig, IRecord record, List<string> keys, Action<List<UnityWebRequest.Result>> callback)
        {

        }
        public async Task<List<bool>> DeleteKeysAsync(IDBConfig dBConfig, IRecord record, List<string> keys)
        {

        }
        public async Task<List<UnityWebRequest.Result>> DeleteKeysAsync(IDBConfig dBConfig, IRecord record, List<string> keys)
        {

        }

        public void DeleteAll(IDBConfig dBConfig, IRecord record)
        {

        }
        public void DeleteAll(IDBConfig dBConfig, IRecord record, Action<List<bool>> callback)
        {

        }
        public void DeleteAll(IDBConfig dBConfig, IRecord record, Action<List<UnityWebRequest.Result>> callback)
        {

        }
        public async Task<bool> DeleteAllAsync(IDBConfig dBConfig, IRecord record)
        {

        }
        public async Task<List<UnityWebRequest.Result>> DeleteAllAsync(IDBConfig dBConfig, IRecord record)
        {

        }
        #endregion

        #region for boolean
        public bool GetBool(IDBConfig dBConfig, IRecord record, string key)
        {
            
        }
        public void GetBool(IDBConfig dBConfig, IRecord record, string key, Action<List<bool>> callback)
        {

        }
        public void GetBool(IDBConfig dBConfig, IRecord record, string key, Action<List<UnityWebRequest.Result>> callback)
        {

        }
        public async Task<bool> GetBoolAsync(IDBConfig dBConfig, IRecord record, string key)
        {

        }
        public async Task<UnityWebRequest.Result> GetBoolAsync(IDBConfig dBConfig, IRecord record, string key)
        {

        }
        
        public bool GetBool(IDBConfig dBConfig, IRecord record, string key, bool defaultValue)
        {

        }
        public void GetBool(IDBConfig dBConfig, IRecord record, string key, bool defaultValue, Action<List<bool>> callback)
        {

        }
        public void GetBool(IDBConfig dBConfig, IRecord record, string key, bool defaultValue, Action<List<UnityWebRequest.Result>> callback)
        {

        }
        public async Task<bool> GetBoolAsync(IDBConfig dBConfig, IRecord record, string key, bool defaultValue)
        {

        }
        public async Task<UnityWebRequest.Result> GetBoolAsync(IDBConfig dBConfig, IRecord record, string key, bool defaultValue)
        {

        }
        
        public void SetBool(IDBConfig dBConfig, IRecord record, string key, bool value)
        {

        }
        public void SetBool(IDBConfig dBConfig, IRecord record, string key, bool value, Action<bool> callback)
        {

        }
        public void SetBool(IDBConfig dBConfig, IRecord record, string key, bool value, Action<UnityWebRequest.Result> callback)
        {

        }
        public async Task<bool> SetBoolAsync(IDBConfig dBConfig, IRecord record, string key, bool value)
        {

        }
        public async Task<UnityWebRequest.Result> SetBoolAsync(IDBConfig dBConfig, IRecord record, string key, bool value)
        {

        }
        #endregion

        #region for char
        public char GetChar(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetChar(IDBConfig dBConfig, IRecord record, string key, Action<char> callback)
        {
        }
        public void GetChar(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<char> GetCharAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetCharAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetCharAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public char GetChar(IDBConfig dBConfig, IRecord record, string key, char defaultValue)
        {
        }
        public void GetChar(IDBConfig dBConfig, IRecord record, string key, char defaultValue, Action<char> callback)
        {
        }
        public void GetChar(IDBConfig dBConfig, IRecord record, string key, char defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<char> GetCharAsync(IDBConfig dBConfig, IRecord record, string key, char defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetCharAsync(IDBConfig dBConfig, IRecord record, string key, char defaultValue)
        {
        }

        public void SetChar(IDBConfig dBConfig, IRecord record, string key, char value)
        {
        }
        public void SetChar(IDBConfig dBConfig, IRecord record, string key, char value, Action<bool> callback)
        {
        }
        public void SetChar(IDBConfig dBConfig, IRecord record, string key, char value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetCharAsync(IDBConfig dBConfig, IRecord record, string key, char value)
        {
        }
        public async Task<UnityWebRequest.Result> SetCharAsync(IDBConfig dBConfig, IRecord record, string key, char value)
        {
        }
        #endregion

        #region for Color
        public Color GetColor(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetColor(IDBConfig dBConfig, IRecord record, string key, Action<Color> callback)
        {
        }
        public void GetColor(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Color> GetColorAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetColorAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetColorAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public Color GetColor(IDBConfig dBConfig, IRecord record, string key, Color defaultColor)
        {
        }
        public void GetColor(IDBConfig dBConfig, IRecord record, string key, Color defaultColor, Action<Color> callback)
        {
        }
        public void GetColor(IDBConfig dBConfig, IRecord record, string key, Color defaultColor, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Color> GetColorAsync(IDBConfig dBConfig, IRecord record, string key, Color defaultColor)
        {
        }
        public async Task<UnityWebRequest.Result> GetColorAsync(IDBConfig dBConfig, IRecord record, string key, Color defaultColor)
        {
        }

        public void SetColor(IDBConfig dBConfig, IRecord record, string key, Color color)
        {
        }
        public void SetColor(IDBConfig dBConfig, IRecord record, string key, Color color, Action<Color> callback)
        {
        }
        public void SetColor(IDBConfig dBConfig, IRecord record, string key, Color color, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetColorAsync(IDBConfig dBConfig, IRecord record, string key, Color color)
        {
        }
        public async Task<UnityWebRequest.Result> SetColorAsync(IDBConfig dBConfig, IRecord record, string key, Color color)
        {
        }
        #endregion

        #region for double
        public double GetDouble(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetDouble(IDBConfig dBConfig, IRecord record, string key, Action<double> callback)
        {
        }
        public void GetDouble(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<double> GetDoubleAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetDoubleAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetDoubleAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public double GetDouble(IDBConfig dBConfig, IRecord record, string key, double defaultValue)
        {
        }
        public void GetDouble(IDBConfig dBConfig, IRecord record, string key, double defaultValue, Action<double> callback)
        {
        }
        public void GetDouble(IDBConfig dBConfig, IRecord record, string key, double defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<double> GetDoubleAsync(IDBConfig dBConfig, IRecord record, string key, double defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetDoubleAsync(IDBConfig dBConfig, IRecord record, string key, double defaultValue)
        {
        }

        public void SetDouble(IDBConfig dBConfig, IRecord record, string key, double value)
        {
        }
        public void SetDouble(IDBConfig dBConfig, IRecord record, string key, double value, Action<bool> callback)
        {
        }
        public void SetDouble(IDBConfig dBConfig, IRecord record, string key, double value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetDoubleAsync(IDBConfig dBConfig, IRecord record, string key, double value)
        {
        }
        public async Task<UnityWebRequest.Result> SetDoubleAsync(IDBConfig dBConfig, IRecord record, string key, double value)
        {
        }
        #endregion

        #region for String
        public string GetString(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetString(IDBConfig dBConfig, IRecord record, string key, Action<string> callback)
        {
        }
        public void GetString(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<string> GetStringAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetStringAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetStringAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public string GetString(IDBConfig dBConfig, IRecord record, string key, string defaultValue)
        {
        }
        public void GetString(IDBConfig dBConfig, IRecord record, string key, string defaultValue, Action<string> callback)
        {
        }
        public void GetString(IDBConfig dBConfig, IRecord record, string key, string defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<string> GetStringAsync(IDBConfig dBConfig, IRecord record, string key, string defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetStringAsync(IDBConfig dBConfig, IRecord record, string key, string defaultValue)
        {
        }

        public void SetString(IDBConfig dBConfig, IRecord record, string key, string value)
        {
        }
        public void SetString(IDBConfig dBConfig, IRecord record, string key, string value, Action<bool> callback)
        {
        }
        public void SetString(IDBConfig dBConfig, IRecord record, string key, string value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetStringAsync(IDBConfig dBConfig, IRecord record, string key, string value)
        {
        }
        public async Task<UnityWebRequest.Result> SetStringAsync(IDBConfig dBConfig, IRecord record, string key, string value)
        {
        }
        #endregion

        #region for Int
        public int GetInt(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetInt(IDBConfig dBConfig, IRecord record, string key, Action<int> callback)
        {
        }
        public void GetInt(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<int> GetIntAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetIntAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetIntAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public int GetInt(IDBConfig dBConfig, IRecord record, string key, int defaultValue)
        {
        }
        public void GetInt(IDBConfig dBConfig, IRecord record, string key, int defaultValue, Action<int> callback)
        {
        }
        public void GetInt(IDBConfig dBConfig, IRecord record, string key, int defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<int> GetIntAsync(IDBConfig dBConfig, IRecord record, string key, int defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetIntAsync(IDBConfig dBConfig, IRecord record, string key, int defaultValue)
        {
        }

        public void SetInt(IDBConfig dBConfig, IRecord record, string key, int value)
        {
        }
        public void SetInt(IDBConfig dBConfig, IRecord record, string key, int value, Action<bool> callback)
        {
        }
        public void SetInt(IDBConfig dBConfig, IRecord record, string key, int value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetIntAsync(IDBConfig dBConfig, IRecord record, string key, int value)
        {
        }
        public async Task<UnityWebRequest.Result> SetIntAsync(IDBConfig dBConfig, IRecord record, string key, int value)
        {
        }
        #endregion

        #region for float
        public float GetFloat(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetFloat(IDBConfig dBConfig, IRecord record, string key, Action<float> callback)
        {
        }
        public void GeFloat(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<float> GetFloatAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetFloatAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetFloatAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public float GetFloat(IDBConfig dBConfig, IRecord record, string key, float defaultValue)
        {
        }
        public void GetFloat(IDBConfig dBConfig, IRecord record, string key, float defaultValue, Action<float> callback)
        {
        }
        public void GetFloat(IDBConfig dBConfig, IRecord record, string key, float defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<float> GetFloatAsync(IDBConfig dBConfig, IRecord record, string key, float defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetFloatAsync(IDBConfig dBConfig, IRecord record, string key, float defaultValue)
        {
        }

        public void SetFloat(IDBConfig dBConfig, IRecord record, string key, float value)
        {
        }
        public void SetFloat(IDBConfig dBConfig, IRecord record, string key, float value, Action<bool> callback)
        {
        }
        public void SetFloat(IDBConfig dBConfig, IRecord record, string key, float value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetFloatAsync(IDBConfig dBConfig, IRecord record, string key, float value)
        {
        }
        public async Task<UnityWebRequest.Result> SetFloatAsync(IDBConfig dBConfig, IRecord record, string key, float value)
        {
        }
        #endregion

        #region for Vector2
        public Vector2 GetVector2(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetVector2(IDBConfig dBConfig, IRecord record, string key, Action<Vector2> callback)
        {
        }
        public void GetVector2(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Vector2> GetVector2Async(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetVector2Async(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetVector2Async(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public Vector2 GetVector2(IDBConfig dBConfig, IRecord record, string key, Vector2 defaultValue)
        {
        }
        public void GetVector2(IDBConfig dBConfig, IRecord record, string key, Vector2 defaultValue, Action<Vector2> callback)
        {
        }
        public void GetVector2(IDBConfig dBConfig, IRecord record, string key, Vector2 defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Vector2> GetVector2Async(IDBConfig dBConfig, IRecord record, string key, Vector2 defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetVector2Async(IDBConfig dBConfig, IRecord record, string key, Vector2 defaultValue)
        {
        }

        public void SetVector2(IDBConfig dBConfig, IRecord record, string key, Vector2 value)
        {
        }
        public void SetVector2(IDBConfig dBConfig, IRecord record, string key, Vector2 value, Action<bool> callback)
        {
        }
        public void SetVector2(IDBConfig dBConfig, IRecord record, string key, Vector2 value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetVector2Async(IDBConfig dBConfig, IRecord record, string key, Vector2 value)
        {
        }
        public async Task<UnityWebRequest.Result> SetVector2Async(IDBConfig dBConfig, IRecord record, string key, Vector2 value)
        {
        }
        #endregion

        #region for Vector2Int
        public Vector2Int GetVector2Int(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetVector2Int(IDBConfig dBConfig, IRecord record, string key, Action<Vector2Int> callback)
        {
        }
        public void GetVector2Int(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Vector2Int> GetVector2IntAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetVector2IntAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetVector2IntAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public Vector2Int GetVector2Int(IDBConfig dBConfig, IRecord record, string key, Vector2Int defaultValue)
        {
        }
        public void GetVector2Int(IDBConfig dBConfig, IRecord record, string key, Vector2Int defaultValue, Action<Vector2Int> callback)
        {
        }
        public void GetVector2Int(IDBConfig dBConfig, IRecord record, string key, Vector2Int defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Vector2Int> GetVector2IntAsync(IDBConfig dBConfig, IRecord record, string key, Vector2Int defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetVector2IntAsync(IDBConfig dBConfig, IRecord record, string key, Vector2Int defaultValue)
        {
        }

        public void SetVector2Int(IDBConfig dBConfig, IRecord record, string key, Vector2Int value)
        {
        }
        public void SetVector2Int(IDBConfig dBConfig, IRecord record, string key, Vector2Int value, Action<bool> callback)
        {
        }
        public void SetVector2Int(IDBConfig dBConfig, IRecord record, string key, Vector2Int value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetVector2IntAsync(IDBConfig dBConfig, IRecord record, string key, Vector2Int value)
        {
        }
        public async Task<UnityWebRequest.Result> SetVector2IntAsync(IDBConfig dBConfig, IRecord record, string key, Vector2Int value)
        {
        }
        #endregion

        #region for Vector3
        public Vector3 GetVector3(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetVector3(IDBConfig dBConfig, IRecord record, string key, Action<Vector3> callback)
        {
        }
        public void GetVector3(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Vector3> GetVector3Async(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetVector3Async(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetVector3Async(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public Vector3 GetVector3(IDBConfig dBConfig, IRecord record, string key, Vector3 defaultValue)
        {
        }
        public void GetVector3(IDBConfig dBConfig, IRecord record, string key, Vector3 defaultValue, Action<Vector3> callback)
        {
        }
        public void GetVector3(IDBConfig dBConfig, IRecord record, string key, Vector3 defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Vector3> GetVector3Async(IDBConfig dBConfig, IRecord record, string key, Vector3 defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetVector3Async(IDBConfig dBConfig, IRecord record, string key, Vector3 defaultValue)
        {
        }

        public void SetVector3(IDBConfig dBConfig, IRecord record, string key, Vector3 value)
        {
        }
        public void SetVector3(IDBConfig dBConfig, IRecord record, string key, Vector3 value, Action<bool> callback)
        {
        }
        public void SetVector3(IDBConfig dBConfig, IRecord record, string key, Vector3 value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetVector3Async(IDBConfig dBConfig, IRecord record, string key, Vector3 value)
        {
        }
        public async Task<UnityWebRequest.Result> SetVector3Async(IDBConfig dBConfig, IRecord record, string key, Vector3 value)
        {
        }
        #endregion

        #region for Vector3Int
        public Vector3Int GetVector3Int(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetVector3Int(IDBConfig dBConfig, IRecord record, string key, Action<Vector3Int> callback)
        {
        }
        public void GetVector3Int(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Vector3Int> GetVector3IntAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetVector3IntAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetVector3IntAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public Vector3Int GetVector3Int(IDBConfig dBConfig, IRecord record, string key, Vector3Int defaultValue)
        {
        }
        public void GetVector3Int(IDBConfig dBConfig, IRecord record, string key, Vector3Int defaultValue, Action<Vector3Int> callback)
        {
        }
        public void GetVector3Int(IDBConfig dBConfig, IRecord record, string key, Vector3Int defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Vector3Int> GetVector3IntAsync(IDBConfig dBConfig, IRecord record, string key, Vector3Int defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetVector3IntAsync(IDBConfig dBConfig, IRecord record, string key, Vector3Int defaultValue)
        {
        }

        public void SetVector3Int(IDBConfig dBConfig, IRecord record, string key, Vector3Int value)
        {
        }
        public void SetVector3Int(IDBConfig dBConfig, IRecord record, string key, Vector3Int value, Action<bool> callback)
        {
        }
        public void SetVector3Int(IDBConfig dBConfig, IRecord record, string key, Vector3Int value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetVector3IntAsync(IDBConfig dBConfig, IRecord record, string key, Vector3Int value)
        {
        }
        public async Task<UnityWebRequest.Result> SetVector3IntAsync(IDBConfig dBConfig, IRecord record, string key, Vector3Int value)
        {
        }
        #endregion

        #region for Vector4
        public Vector4 GetVector4(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetVector4(IDBConfig dBConfig, IRecord record, string key, Action<Vector4> callback)
        {
        }
        public void GetVector4(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Vector4> GetVector4Async(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetVector4Async(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetVector4Async(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public Vector4 GetVector4(IDBConfig dBConfig, IRecord record, string key, Vector4 defaultValue)
        {
        }
        public void GetVector4(IDBConfig dBConfig, IRecord record, string key, Vector4 defaultValue, Action<Vector4> callback)
        {
        }
        public void GetVector4(IDBConfig dBConfig, IRecord record, string key, Vector4 defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Vector4> GetVector4Async(IDBConfig dBConfig, IRecord record, string key, Vector4 defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetVector4Async(IDBConfig dBConfig, IRecord record, string key, Vector4 defaultValue)
        {
        }

        public void SetVector4(IDBConfig dBConfig, IRecord record, string key, Vector4 value)
        {
        }
        public void SetVector4(IDBConfig dBConfig, IRecord record, string key, Vector4 value, Action<bool> callback)
        {
        }
        public void SetVector4(IDBConfig dBConfig, IRecord record, string key, Vector4 value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetVector4Async(IDBConfig dBConfig, IRecord record, string key, Vector4 value)
        {
        }
        public async Task<UnityWebRequest.Result> SetVector4Async(IDBConfig dBConfig, IRecord record, string key, Vector4 value)
        {
        }
        #endregion

        #region for Quaternion
        public Quaternion GetQuaternion(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetQuaternion(IDBConfig dBConfig, IRecord record, string key, Action<Quaternion> callback)
        {
        }
        public void GetQuaternion(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Quaternion> GetQuaternionAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetQuaternionAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetQuaternionAsync(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public Quaternion GetQuaternion(IDBConfig dBConfig, IRecord record, string key, Quaternion defaultValue)
        {
        }
        public void GetQuaternion(IDBConfig dBConfig, IRecord record, string key, Quaternion defaultValue, Action<Quaternion> callback)
        {
        }
        public void GetQuaternion(IDBConfig dBConfig, IRecord record, string key, Quaternion defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<Quaternion> GetQuaternionAsync(IDBConfig dBConfig, IRecord record, string key, Quaternion defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetQuaternionAsync(IDBConfig dBConfig, IRecord record, string key, Quaternion defaultValue)
        {
        }

        public void SetQuaternion(IDBConfig dBConfig, IRecord record, string key, Quaternion value)
        {
        }
        public void SetQuaternion(IDBConfig dBConfig, IRecord record, string key, Quaternion value, Action<bool> callback)
        {
        }
        public void SetQuaternion(IDBConfig dBConfig, IRecord record, string key, Quaternion value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetQuaternionAsync(IDBConfig dBConfig, IRecord record, string key, Quaternion value)
        {
        }
        public async Task<UnityWebRequest.Result> SetQuaternionAsync(IDBConfig dBConfig, IRecord record, string key, Quaternion value)
        {
        }
        #endregion

        #region for Generic
        public T GetGeneric<T>(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public void GetGeneric<T>(IDBConfig dBConfig, IRecord record, string key, Action<T> callback)
        {
        }
        public void GetGeneric<T>(IDBConfig dBConfig, IRecord record, string key, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<T> GetGenericAsync<T>(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<bool> TryGetGenericAsync<T>(IDBConfig dBConfig, IRecord record, string key)
        {
        }
        public async Task<UnityWebRequest.Result> GetGenericAsync<T>(IDBConfig dBConfig, IRecord record, string key)
        {
        }

        public T GetGeneric<T>(IDBConfig dBConfig, IRecord record, string key, T defaultValue)
        {
        }
        public void GetGeneric<T>(IDBConfig dBConfig, IRecord record, string key, T defaultValue, Action<T> callback)
        {
        }
        public void GetGeneric<T>(IDBConfig dBConfig, IRecord record, string key, T defaultValue, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<T> GetGenericAsync<T>(IDBConfig dBConfig, IRecord record, string key, T defaultValue)
        {
        }
        public async Task<UnityWebRequest.Result> GetGenericAsync<T>(IDBConfig dBConfig, IRecord record, string key, T defaultValue)
        {
        }

        public void SetGeneric<T>(IDBConfig dBConfig, IRecord record, string key, T value)
        {
        }
        public void SetGeneric<T>(IDBConfig dBConfig, IRecord record, string key, T value, Action<bool> callback)
        {
        }
        public void SetGeneric<T>(IDBConfig dBConfig, IRecord record, string key, T value, Action<UnityWebRequest.Result> callback)
        {
        }
        public async Task<bool> SetGenericAsync<T>(IDBConfig dBConfig, IRecord record, string key, T value)
        {
        }
        public async Task<UnityWebRequest.Result> SetGenericAsync<T>(IDBConfig dBConfig, IRecord record, string key, T value)
        {
        }
        #endregion
    }
}