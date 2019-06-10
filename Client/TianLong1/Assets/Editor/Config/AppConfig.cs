using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class AppConfig  {

    public static bool DataImport = false;


    [MenuItem("Config/OpenDataImport", false, 1)]
    private static void OpenDataImport()
    {
        DataImport = true;
        DebugT.Log("开启文件自动导入!");
    }
    [MenuItem("Config/CloseDataImport", false, 1)]
    private static void CloseDataImport()
    {
        DebugT.Log("关闭文件自动导入!");
        DataImport = false;
    }
}
