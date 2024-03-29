using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace Nesco.EPP
{
    using static RequestOperate;
    public class DataGateway
    {
        private const string CHECK_KEY = "/HEXISTS/";
        private const string DELETE_KEY = "/HDEL/";
        private const string DATA_SET = "/HSET/";
        private const string DELETE_RECORD = "/DEL/";

        public static async void HasKeyRequest<T>(IDBConfig dBConfig, IRecord record, string key, Action<ResultSet<T>> callback, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  CHECK_KEY,
                                                                                  record.RecordHash,
                                                                                  key)))
            {
                if (dBConfig.Readonly)
                    req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.ReadonlyAuthorizationHeaderValue);
                else
                    req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                    callback(resultSet);
                    return;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text) && req.downloadHandler.text.Contains("1");

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;
                callback(resultSet);
            }
        }
        public static async void HasKeyRequestAsync<T>(IDBConfig dBConfig, IRecord record, string key, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  CHECK_KEY,
                                                                                  record.RecordHash,
                                                                                  key)))
            {
                if (dBConfig.Readonly)
                    req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.ReadonlyAuthorizationHeaderValue);
                else
                    req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                    return;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text) && req.downloadHandler.text.Contains("1");

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;
            }
        }

        public static void DeleteKeyRequest(IDBConfig dBConfig, IRecord record, string key)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DELETE_KEY,
                                                                                  record.RecordHash,
                                                                                  key)))
            {
                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);
                req.SendWebRequest();
            }
        }
        public static async void DeleteKeyRequest<T>(IDBConfig dBConfig, IRecord record, string key, Action<ResultSet<T>> callback, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DELETE_KEY,
                                                                                  record.RecordHash,
                                                                                  key)))
            {

                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                    callback(resultSet);
                    return;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;
                callback(resultSet);
            }
        }
        public static async void DeleteKeyRequestAsync<T>(IDBConfig dBConfig, IRecord record, string key, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DELETE_KEY,
                                                                                  record.RecordHash,
                                                                                  key)))
            {

                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                    return;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;
            }
        }

        public static async void SetStringRequest(IDBConfig dBConfig, IRecord record, string key, string value)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DATA_SET,
                                                                                  record.RecordHash,
                                                                                  key,
                                                                                  value)))
            {

                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();
            }
        }
        public static async void SetStringRequest<T>(IDBConfig dBConfig, IRecord record, string key, string value, Action<ResultSet<T>> callback, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Post(Get_PostRequestString(dBConfig.RestURL, DATA_SET, record.RecordHash, key), value, "application/text"))
            {
                req.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(value));
                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                    callback(resultSet);
                    return;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;

                callback(resultSet);
            }
        }
        public static async void SetStringRequestAsync<T>(IDBConfig dBConfig, IRecord record, string key, string value, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Post(Get_PostRequestString(dBConfig.RestURL, DATA_SET, record.RecordHash, key), value, "application/text"))
            {
                req.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(value));
                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                    return;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;
            }
        }

        public static void DeleteKeysRequest(IDBConfig dBConfig, IRecord record, string[] keys)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DELETE_KEY,
                                                                                  record.RecordHash,
                                                                                  keys)))
            {

                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);
                req.SendWebRequest();
            }
        }
        public static async void DeleteKeysRequest<T>(IDBConfig dBConfig, IRecord record, string[] keys, Action<ResultSet<T>> callback, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DELETE_KEY,
                                                                                  record.RecordHash,
                                                                                  keys)))
            {

                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                    callback(resultSet);
                    return;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;
                callback(resultSet);
            }
        }
        public static async void DeleteKeysRequestAsync<T>(IDBConfig dBConfig, IRecord record, string[] keys, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DELETE_KEY,
                                                                                  record.RecordHash,
                                                                                  keys)))
            {

                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                    return;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;
            }
        }

        public static void DeleteAllRequest(IDBConfig dBConfig, IRecord record)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DELETE_RECORD,
                                                                                  record.RecordHash)))
            {

                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);
                req.SendWebRequest();
            }
        }
        public static async void DeleteAllRequest<T>(IDBConfig dBConfig, IRecord record, Action<ResultSet<T>> callback, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DELETE_RECORD,
                                                                                  record.RecordHash)))
            {

                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                    callback(resultSet);
                    return;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;
                callback(resultSet);
            }
        }
        public static async void DeleteAllRequestAsync<T>(IDBConfig dBConfig, IRecord record, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DELETE_RECORD,
                                                                                  record.RecordHash)))
            {

                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                    return;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;
            }
        }

        public static void SetBoolRequest(IDBConfig dBConfig, IRecord record, string key, bool value)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DATA_SET,
                                                                                  record.RecordHash,
                                                                                  key,
                                                                                  value.ToString())))
            {

                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);
                req.SendWebRequest();
            }
        }
        public static async void SetBoolRequest<T>(IDBConfig dBConfig, IRecord record, string key, bool value, Action<ResultSet<T>> callback, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DATA_SET,
                                                                                  record.RecordHash,
                                                                                  key,
                                                                                  value.ToString())))
            {

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                    callback(resultSet);
                    return;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;
                callback(resultSet);
            }
        }
        public static async void SetBoolRequestAsync<T>(IDBConfig dBConfig, IRecord record, string key, bool value, ResultSet<T> resultSet)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  DATA_SET,
                                                                                  record.RecordHash,
                                                                                  key,
                                                                                  value.ToString())))
            {

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                {
                    resultSet.IsDone = true;
                    resultSet.RequestResult = req.result;
                    resultSet.Value = (T)(object)false;
                }

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                resultSet.IsDone = true;
                resultSet.RequestResult = req.result;
                resultSet.Value = (T)(object)state;
            }
        }
        /////// Server Json response examples
        // { "result": "OK" }
        // { "result": null }
        // { "result": 137 }
        // { "result": "value" }
        // { "result": ["value1", null, "value2"] }
        // {"error":"WRONGPASS invalid password"}
        // {"error":"ERR wrong number of arguments for 'get' command"}

        // [{"result":"RESPONSE_A"},{"result":"RESPONSE_B"},{"error":"ERR ..."}, ...]
    }

    internal class RequestOperate
    {
        internal static string Get_GetRequestString(string url, string command, string recordHash, string key)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            builder.Append(command);
            builder.Append(recordHash);
            builder.Append("/");
            builder.Append(key);
            return builder.ToString();
        }
        internal static string Get_GetRequestString(string url, string command, string recordHash)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            builder.Append(command);
            builder.Append(recordHash);
            return builder.ToString();
        }
        internal static string Get_GetRequestString(string url, string command, string recordHash, string[] keys)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            builder.Append(command);
            builder.Append(recordHash);
            builder.Append("/");
            foreach (var key in keys)
            {
                builder.Append(key);
                builder.Append("/");
            }
            return builder.ToString();
        }
        internal static string Get_GetRequestString(string url, string command, string recordHash, string key, string value)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            builder.Append(command);
            builder.Append(recordHash);
            builder.Append("/");
            builder.Append(key);
            builder.Append("/");
            builder.Append(value);
            return builder.ToString();
        }
        internal static string Get_PostRequestString(string url, string command, string recordHash, string key)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            builder.Append(command);
            builder.Append(recordHash);
            builder.Append("/");
            builder.Append(key);
            builder.Append("/");
            return builder.ToString();
        }
        internal static string Get_PostRequestString(string url, string command, string recordHash, string[] keys)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            builder.Append(command);
            builder.Append(recordHash);
            builder.Append("/");
            foreach (var key in keys)
            {
                builder.Append(key);
                builder.Append("/");
            }
            return builder.ToString();
        }
    }

    internal class ResponseOperate
    {
        internal static bool Check(string jsonResponse)
        {
            var dict = Convert(jsonResponse);

            if (dict.ContainsKey("result")) { return true; }

            if (dict.ContainsKey("error")) { return false; }

            return false;
        }
        internal static Dictionary<string, string> Convert(string jsonResponse)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonResponse);
        }
    }
}