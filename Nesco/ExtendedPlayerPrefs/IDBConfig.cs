using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Nesco.EPP
{
    public interface IDBConfig
    {
#nullable enable
        public string? DBName { get; }
#nullable restore
        public string RestURL { get; }
        public string RestToken { get; }

        //Used to configure the request's header when sending a request to Upstash/Redis.
        public string AuthorizationHeaderName { get; }
        public string AuthorizationHeaderValue { get; }
    }

    public class DBConfig : IDBConfig
    {
        private readonly string restURL;
        private readonly string restToken;
        private readonly string dbName;
        private string authorizationHeaderName;
        private string authorizationHeaderValue;

        private const string AUTHORIZATION_HEADER_NAME = "Authorization";
        private const string AUTHORIZATION_HEADER_VALUE_PREFIX = " Bearer ";

        public DBConfig(string restURL, string restToken)
        {
            this.restURL = restURL;
            this.restToken = restToken;
            Init();
        }

        public DBConfig(string dbName, string restURL, string restToken)
        {
            this.dbName = dbName;
            this.restURL = restURL;
            this.restToken = restToken;
            Init();
        }

        private void Init()
        {
            authorizationHeaderName = AUTHORIZATION_HEADER_NAME;
            authorizationHeaderValue = AUTHORIZATION_HEADER_VALUE_PREFIX + restToken;
        }

        public string RestURL
        {
            get { return restURL; }
        }

        public string RestToken
        {
            get { return restToken; }
        }

        public string DBName
        {
            get { return dbName; }
        }

        public string AuthorizationHeaderName
        {
            get { return authorizationHeaderName; }
        }

        public string AuthorizationHeaderValue
        {
            get { return authorizationHeaderValue; }
        }
    }
}