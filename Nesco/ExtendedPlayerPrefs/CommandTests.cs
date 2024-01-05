using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nesco.EPP;
public class CommandTests : MonoBehaviour
{
    [SerializeField] TestResults testResults;
    void Start()
    {
        Tests_Before_Data_Recording();
        Tests_WriteAndRead();
    }

    public void Tests_Before_Data_Recording()
    {
        Test_GetBool_Before_Data_Recording();
        Test_GetChar_Before_Data_Recording();
        Test_GetColor_Before_Data_Recording();
        Test_GetDouble_Before_Data_Recording();
        Test_GetQuaternion_Before_Data_Recording();
        Test_GetVector2_Before_Data_Recording();
        Test_GetVector2Int_Before_Data_Recording();
        Test_GetVector3_Before_Data_Recording();
        Test_GetVector3Int_Before_Data_Recording();
        Test_GetVector4_Before_Data_Recording();
    }
    public void Tests_WriteAndRead()
    {
        Test_Bool_WriteAndRead();
        Test_Char_WriteAndRead();
        Test_Color_WriteAndRead(); ;
        Test_Double_WriteAndRead();
        Test_Quaternion_WriteAndRead();
        Test_Vector2_WriteAndRead();
        Test_Vector2Int_WriteAndRead();
        Test_Vector3_WriteAndRead();
        Test_Vector3Int_WriteAndRead();
        Test_Vector4_WriteAndRead();
    }

    public void Test_GetBool_Before_Data_Recording()
    {
        if (ExtendedPlayerPrefs.GetBool("GetBool", true))
        {
            testResults.Bool_CommandGroup.Before_Data_Recording_With_Param = true;
        }
        if (ExtendedPlayerPrefs.GetBool("GetBool") == default(bool))
        {
            testResults.Bool_CommandGroup.Before_Data_Recording = true;
        }
    }

    public void Test_Bool_WriteAndRead()
    {
        ExtendedPlayerPrefs.SetBool("SetBool", true);
        if (ExtendedPlayerPrefs.GetBool("SetBool"))
        {
            testResults.Bool_CommandGroup.WriteAndRead = true;
        }
    }

    public void Test_GetChar_Before_Data_Recording()
    {
        if (ExtendedPlayerPrefs.GetChar("GetChar", '=') == '=')
        {
            testResults.Char_CommandGroup.Before_Data_Recording_With_Param = true;
        }
        if (ExtendedPlayerPrefs.GetChar("GetChar") == default(char))
        {
            testResults.Char_CommandGroup.Before_Data_Recording = true;
        }
    }
    public void Test_Char_WriteAndRead()
    {
        ExtendedPlayerPrefs.SetChar("SetChar", '=');
        if (ExtendedPlayerPrefs.GetChar("SetChar") == '=')
        {
            testResults.Char_CommandGroup.WriteAndRead = true;
        }
    }

    public void Test_GetColor_Before_Data_Recording()
    {
        if (ExtendedPlayerPrefs.GetColor("GetColor", Color.yellow) == Color.yellow)
        {
            testResults.Color_CommandGroup.Before_Data_Recording_With_Param = true;
        }
        if (ExtendedPlayerPrefs.GetColor("GetColor") == default(Color))
        {
            testResults.Color_CommandGroup.Before_Data_Recording = true;
        }
    }
    public void Test_Color_WriteAndRead()
    {
        ExtendedPlayerPrefs.SetColor("SetColor", Color.yellow);
        if (ExtendedPlayerPrefs.GetColor("SetColor") == Color.yellow)
        {
            testResults.Color_CommandGroup.WriteAndRead = true;
        }
    }

    public void Test_GetDouble_Before_Data_Recording()
    {
        if (ExtendedPlayerPrefs.GetDouble("GetDouble", 34535.7862346d) == 34535.7862346d)
        {
            testResults.Double_CommandGroup.Before_Data_Recording_With_Param = true;
        }
        if (ExtendedPlayerPrefs.GetDouble("GetDouble") == default(double))
        {
            testResults.Double_CommandGroup.Before_Data_Recording = true;
        }
    }
    public void Test_Double_WriteAndRead()
    {
        ExtendedPlayerPrefs.SetDouble("SetDouble", 897345789.42d);
        if (ExtendedPlayerPrefs.GetDouble("SetDouble") == 897345789.42d)
        {
            testResults.Double_CommandGroup.WriteAndRead = true;
        }
    }

    public void Test_GetQuaternion_Before_Data_Recording()
    {
        if (ExtendedPlayerPrefs.GetQuaternion("GetQuaternion", transform.rotation) == transform.rotation)
        {
            testResults.Quaternion_CommandGroup.Before_Data_Recording_With_Param = true;
        }
        if (ExtendedPlayerPrefs.GetQuaternion("GetQuaternion") == default(Quaternion))
        {
            testResults.Quaternion_CommandGroup.Before_Data_Recording = true;
        }
    }
    public void Test_Quaternion_WriteAndRead()
    {
        ExtendedPlayerPrefs.SetQuaternion("SetQuaternion", new Quaternion(23.43f, 234.45f, -123.45f, 543f));
        if (ExtendedPlayerPrefs.GetQuaternion("SetQuaternion") == new Quaternion(23.43f, 234.45f, -123.45f, 543f))
        {
            testResults.Quaternion_CommandGroup.WriteAndRead = true;
        }
    }

    public void Test_GetVector2_Before_Data_Recording()
    {
        if (ExtendedPlayerPrefs.GetVector2("GetVector2", Vector2.one * 123.23523f) == Vector2.one * 123.23523f)
        {
            testResults.Vector2_CommandGroup.Before_Data_Recording_With_Param = true;
        }
        if (ExtendedPlayerPrefs.GetVector2("GetVector2") == default(Vector2))
        {
            testResults.Vector2_CommandGroup.Before_Data_Recording = true;
        }
    }

    public void Test_Vector2_WriteAndRead()
    {
        ExtendedPlayerPrefs.SetVector2("SetVector2", Vector2.one * 972345.548f);
        if (ExtendedPlayerPrefs.GetVector2("SetVector2") == Vector2.one * 972345.548f)
        {
            testResults.Vector2_CommandGroup.WriteAndRead = true;
        }
    }

    public void Test_GetVector2Int_Before_Data_Recording()
    {
        if (ExtendedPlayerPrefs.GetVector2Int("GetVector2Int", Vector2Int.one * 123) == Vector2Int.one * 123)
        {
            testResults.Vector2Int_CommandGroup.Before_Data_Recording_With_Param = true;
        }
        if (ExtendedPlayerPrefs.GetVector2Int("GetVector2Int") == default(Vector2Int))
        {
            testResults.Vector2Int_CommandGroup.Before_Data_Recording = true;
        }
    }
    public void Test_Vector2Int_WriteAndRead()
    {
        ExtendedPlayerPrefs.SetVector2Int("SetVector2Int", Vector2Int.one * 7826345);
        if (ExtendedPlayerPrefs.GetVector2Int("SetVector2Int") == Vector2Int.one * 7826345)
        {
            testResults.Vector2Int_CommandGroup.WriteAndRead = true;
        }
    }

    public void Test_GetVector3_Before_Data_Recording()
    {
        if (ExtendedPlayerPrefs.GetVector3("GetVector3", Vector3.one * 123.23456f) == Vector3.one * 123.23456f)
        {
            testResults.Vector3_CommandGroup.Before_Data_Recording_With_Param = true;
        }
        if (ExtendedPlayerPrefs.GetVector3("GetVector3") == default(Vector3))
        {
            testResults.Vector3_CommandGroup.Before_Data_Recording= true;
        }
    }
    public void Test_Vector3_WriteAndRead()
    {
        ExtendedPlayerPrefs.SetVector3("SetVector3", Vector3.one * 8923745.234267f);
        if (ExtendedPlayerPrefs.GetVector3("SetVector3") == Vector3.one * 8923745.234267f)
        {
            testResults.Vector3_CommandGroup.WriteAndRead = true;
        }
    }

    public void Test_GetVector3Int_Before_Data_Recording()
    {
        if (ExtendedPlayerPrefs.GetVector3Int("GetVector3Int", Vector3Int.one * 123) == Vector3Int.one * 123)
        {
            testResults.Vector3Int_CommandGroup.Before_Data_Recording_With_Param = true;
        }
        if (ExtendedPlayerPrefs.GetVector3Int("GetVector3Int") == default(Vector3Int))
        {
            testResults.Vector3Int_CommandGroup.Before_Data_Recording = true;
        }
    }
    public void Test_Vector3Int_WriteAndRead()
    {
        ExtendedPlayerPrefs.SetVector3Int("SetVector3Int", Vector3Int.one * 734537);
        if (ExtendedPlayerPrefs.GetVector3Int("SetVector3Int") == Vector3Int.one * 734537)
        {
            testResults.Vector3Int_CommandGroup.WriteAndRead = true;
        }
    }

    public void Test_GetVector4_Before_Data_Recording()
    {
        if (ExtendedPlayerPrefs.GetVector4("GetVector4", Vector4.one * 67343.23424f) == Vector4.one * 67343.23424f)
        {
            testResults.Vector4_CommandGroup.Before_Data_Recording_With_Param = true;
        }
        if (ExtendedPlayerPrefs.GetVector4("GetVector4") == default(Vector4))
        {
            testResults.Vector4_CommandGroup.Before_Data_Recording = true;
        }
    }
    public void Test_Vector4_WriteAndRead()
    {
        ExtendedPlayerPrefs.SetVector4("SetVector4", Vector4.one * 76345.21345f);
        if (ExtendedPlayerPrefs.GetVector4("SetVector4") == Vector4.one * 76345.21345f)
        {
            testResults.Vector4_CommandGroup.WriteAndRead = true;
        }
    }
}

[System.Serializable]
public class TestResults 
{
    [field: SerializeField] public CommandGroup Bool_CommandGroup { get; set; }
    [field: SerializeField] public CommandGroup Char_CommandGroup { get; set; }
    [field: SerializeField] public CommandGroup Color_CommandGroup { get; set; }
    [field: SerializeField] public CommandGroup Double_CommandGroup { get; set; }
    [field: SerializeField] public CommandGroup Quaternion_CommandGroup { get; set; }
    [field: SerializeField] public CommandGroup Vector2_CommandGroup { get; set; }
    [field: SerializeField] public CommandGroup Vector2Int_CommandGroup { get; set; }
    [field: SerializeField] public CommandGroup Vector3_CommandGroup { get; set; }
    [field: SerializeField] public CommandGroup Vector3Int_CommandGroup { get; set; }
    [field: SerializeField] public CommandGroup Vector4_CommandGroup { get; set; }
}

[System.Serializable]
public class CommandGroup
{
    [field: SerializeField] public bool Before_Data_Recording { get; set; } = false;
    [field: SerializeField] public bool Before_Data_Recording_With_Param { get; set; } = false;
    [field: SerializeField] public bool WriteAndRead{ get; set; } = false;
}
