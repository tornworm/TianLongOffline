using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugT  {

    public static void Log(object obj)
    {
        Debug.Log(obj);
    }
    public static void LogWarning(object obj)
    {
        Debug.LogWarning(obj);
    }
    public static void LogError(object obj)
    {
        Debug.LogError(obj);
    }

}
