using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Nesco.EPP
{
    public class ResultSet<T>
    {
        public bool IsDone { get; set; } = false;
        public T Value { get; set; }
        public UnityWebRequest.Result RequestResult { get; set; }
    }
}