using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Nesco.EPP
{
    public interface IRecord
    {
        public string RecordHash { get; }
    }

    public class Record : IRecord
    {
        private readonly string recordHash;

        public Record(string playerID)
        {
            recordHash = ComputeSHA256Hash(playerID);
        }

        public Record(string playerID, string ID, IDIndicate idIndicate)
        {
            recordHash = ComputeSHA256Hash(playerID + ID + idIndicate.GetHashCode());
        }
        
        public Record(string playerID, string platformID, string sessionID)
        {
            recordHash = ComputeSHA256Hash(playerID + platformID + sessionID);
        }

        private string ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a StringBuilder to collect the bytes and create a string representation.
                StringBuilder builder = new StringBuilder();

                // Loop through each byte of the hashed data and format it as a hexadecimal string.
                foreach (byte b in data)
                {
                    builder.Append(b.ToString("x2"));
                }

                // Return the hexadecimal string.
                return builder.ToString();
            }
        }

        public string RecordHash
        {
            get { return recordHash; }
        }
    }
}
