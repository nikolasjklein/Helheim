using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Heditor_CheckDebug : EditorWindow
{
    [MenuItem("Heditor/CheckDebug")]
    public static void DebugCheck()
    {
        Debug.Log("Initializing Debug Log...");
        Debug.Log("Debug Log ready!");
        Debug.LogWarning("Debug Log Warning ready!");
        Debug.LogError("Debug Log Error ready!");
    }
}
