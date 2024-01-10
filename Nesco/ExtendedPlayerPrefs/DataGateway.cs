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

        public static async void HasKeyRequest(IDBConfig dBConfig, IRecord record, string key, Action<bool> callback)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  CHECK_KEY,
                                                                                  record.RecordHash,
                                                                                  key)))
            {
                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                callback(req.downloadHandler.text.Contains("1"));
            }
        }
        public static async void HasKeyRequest(IDBConfig dBConfig, IRecord record, string key, Action<Tuple<bool, UnityWebRequest.Result>> callback)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  CHECK_KEY,
                                                                                  record.RecordHash,
                                                                                  key)))
            {
                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                callback(new Tuple<bool, UnityWebRequest.Result>(req.downloadHandler.text.Contains("1"), req.result));
            }
        }
        public static async Task<bool> HasKeyRequestAsync(IDBConfig dBConfig, IRecord record, string key)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  CHECK_KEY,
                                                                                  record.RecordHash,
                                                                                  key)))
            {
                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                return req.downloadHandler.text.Contains("1");
            }
        }
        public static async Task<Tuple<bool, UnityWebRequest.Result>> HasKeyRequestAsyncResultset(IDBConfig dBConfig, IRecord record, string key)
        {
            using (UnityWebRequest req = UnityWebRequest.Get(Get_GetRequestString(dBConfig.RestURL,
                                                                                  CHECK_KEY,
                                                                                  record.RecordHash,
                                                                                  key)))
            {
                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                return new Tuple<bool, UnityWebRequest.Result>(req.downloadHandler.text.Contains("1"), req.result);
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
        public static async void DeleteKeyRequest(IDBConfig dBConfig, IRecord record, string key, Action<bool> callback)
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

                callback(req.downloadHandler.text.Contains("1"));
            }
        }
        public static async void DeleteKeyRequest(IDBConfig dBConfig, IRecord record, string key, Action<Tuple<bool, UnityWebRequest.Result>> callback)
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

                callback(new Tuple<bool, UnityWebRequest.Result>(req.downloadHandler.text.Contains("1"), req.result));
            }
        }
        public static async Task<bool> DeleteKeyRequestAsync(IDBConfig dBConfig, IRecord record, string key)
        {
            return await PerformDeleteKeyAsync<bool>(dBConfig, record, key);
        }
        public static async Task<Tuple<bool, UnityWebRequest.Result>> DeleteKeyRequestAsyncResultset(IDBConfig dBConfig, IRecord record, string key)
        {
            return await PerformDeleteKeyAsync<Tuple<bool, UnityWebRequest.Result>>(dBConfig, record, key);
        }
        private static async Task<T> PerformDeleteKeyAsync<T>(IDBConfig dBConfig, IRecord record, string key)
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

                if (typeof(T) == typeof(bool))
                    return (T)(object)req.downloadHandler.text.Contains("1");
                else
                    return (T)(object)new Tuple<bool, UnityWebRequest.Result>(req.downloadHandler.text.Contains("1"), req.result);
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
        public static async void SetStringRequest(IDBConfig dBConfig, IRecord record, string key, string value, Action<bool> callback)
        {
            using (UnityWebRequest req = UnityWebRequest.Post(Get_PostRequestString(dBConfig.RestURL, DATA_SET, record.RecordHash, key), value, "application/text"))
            {
                req.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(value));
                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                    callback(false);

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                callback(state);
            }
        }
        public static async void SetStringRequest(IDBConfig dBConfig, IRecord record, string key, string value, Action<Tuple<bool, UnityWebRequest.Result>> callback)
        {
            using (UnityWebRequest req = UnityWebRequest.Post(Get_PostRequestString(dBConfig.RestURL, DATA_SET, record.RecordHash, key), value, "application/text"))
            {
                req.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(value));
                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                    callback(new Tuple<bool, UnityWebRequest.Result>(false, req.result));

                bool state = ResponseOperate.Check(req.downloadHandler.text);

                callback(new Tuple<bool, UnityWebRequest.Result>(state, req.result));
            }
        }
        public static async Task<bool> SetStringRequestAsync(IDBConfig dBConfig, IRecord record, string key, string value)
        {
            using (UnityWebRequest req = UnityWebRequest.Post(Get_PostRequestString(dBConfig.RestURL, DATA_SET, record.RecordHash, key), value, "application/text"))
            {
                req.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(value));
                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                    return false;

                bool state = ResponseOperate.Check(req.downloadHandler.text);
                return state;
            }
        }
        public static async Task<Tuple<bool, UnityWebRequest.Result>> SetStringRequestAsyncResultset(IDBConfig dBConfig, IRecord record, string key, string value)
        {
            using (UnityWebRequest req = UnityWebRequest.Post(Get_PostRequestString(dBConfig.RestURL, DATA_SET, record.RecordHash, key), value, "application/text"))
            {
                req.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(value));
                req.SetRequestHeader(dBConfig.AuthorizationHeaderName, dBConfig.AuthorizationHeaderValue);

                UnityWebRequestAsyncOperation asyncOperation = req.SendWebRequest();

                while (!asyncOperation.isDone)
                    await Task.Yield();

                if (req.result != UnityWebRequest.Result.Success)
                    return new Tuple<bool, UnityWebRequest.Result>(false, req.result);

                bool state = ResponseOperate.Check(req.downloadHandler.text);
                return new Tuple<bool, UnityWebRequest.Result>(state, req.result);
            }
        }



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