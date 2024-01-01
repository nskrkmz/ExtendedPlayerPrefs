using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Nesco.EPP
{
    public class ExtendedPlayerPrefs : PlayerPrefs
    {
        private static bool IsKeyFormatValid(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key), $"argument {nameof(key)} cannot be null or white space.");

            return true;
        }
    }
}

