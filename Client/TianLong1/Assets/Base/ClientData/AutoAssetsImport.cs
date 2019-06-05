using UnityEngine;
using UnityEditor;
using System.IO;
using System;


namespace Ttxt1
{

    public class AutoAssetsImport : AssetPostprocessor
    {

        void OnPreprocessTexture()
        {
            TextureImporter importer = (TextureImporter)assetImporter;
            importer.textureType = TextureImporterType.Sprite;
            importer.mipmapEnabled = false;
        }
        static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            foreach (string str in importedAssets)
            {

                {
                    txtData(str);

                    AssetDatabase.Refresh();

                }
            }

        }
        static void UIPrefabDataTools(string str)
        {

        }
        static void txtData(string str)
        {
            if (str.EndsWith(".txt")&&str.Contains("Data"))
            {
                string[] arrayt = str.Split('/');
                string[] nextarray = arrayt[arrayt.Length - 1].Split('.');
                Debug.Log("数据发生变化，请查看Scripts/Data文件夹下脚本");
                string name = (nextarray[0]);
                string CurDir = Application.dataPath + "/Scripts/Data/";
                if (!Directory.Exists(CurDir))
                {
                    Directory.CreateDirectory(CurDir);
                }
                //生成的文件路径和名字
                String FilePath = CurDir + name + ".cs";
                //生成文件/覆盖文件
                StreamWriter file = new StreamWriter(FilePath, false);
                //写入信息
                file.Write("using System.Collections;\n");
                file.Write("using System.Collections.Generic;\n");
                file.Write("using UnityEngine;\n");
                file.Write("using System.IO;\n");
                file.Write("\n");
                file.Write("public class ");
                file.Write(name);
                file.Write("\n{\n");
                StreamReader sr = File.OpenText(str);
                string titleText;
                titleText = sr.ReadLine();
                string[] array = titleText.Split('\t');
                //instance
                file.Write("private static " + name + " instance;\n");
                file.Write("public static " + name + " Singleton {\n" + "\tget {\n");
                file.Write("\t\tif (instance==null)\n" + "\t\t\tinstance = new " + name + "();\n" + "\t\treturn instance;\n\t}\t\n}\n");
                file.Write("public " + name + "(){\n" + "\tOnload();\n");
                file.Write("}\n");
                //生成列数字段
                file.Write("private int row = " + array.Length + ";//列数\n");
                //生成List字段
                for (int i = 0; i < array.Length; i++)
                {
                    file.Write("public List<string>" + "list" + i + "=new List<string>();//" + i + "\n");
                }
                //生成方法
                for (int i = 1; i < array.Length; i++)
                {
                    file.Write("  public string Get" + array[i] + "(int id)\n" + "{\n");
                    file.Write("    return " + "list" + i + "[id]" + ";\n" + "}\n");
                }
                file.Write("public void Onload()\n {");
                file.Write("       StreamReader sr = File.OpenText(" + "\"" + str + "\"" + ");\n");
                file.Write("       string lineText;\n");
                file.Write("       lineText=sr.ReadLine();\n");
                file.Write("       string[] lines = File.ReadAllLines(" + "\"" + str + "\"" + ");\n");

                file.Write("       while ((lineText = sr.ReadLine()) != null){\n");
                file.Write("\n        for(int i=0;i<lines.Length;i++)\n");
                file.Write("        {\n");
                file.Write(@"       string[] lineArray = lines[i].Split('\t'); " + " \n");

                string str1 = File.ReadAllLines(str)[0];
                string[] strLength = str1.Split('\t');
                for (int i = 0; i < array.Length; i++)
                {
                    file.Write("             list" + i + ".Add(lineArray[" + i + "]);\n");
                }
                file.Write("        }\n");
                file.Write("}\n");
                file.Write("    \n}\n");
                file.Write("    \n}\n");
                file.Close();
                file.Dispose();
            }
        }
    }
}