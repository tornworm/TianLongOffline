using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Data_Weapon
{
private static Data_Weapon instance;
public static Data_Weapon Singleton {
	get {
		if (instance==null)
			instance = new Data_Weapon();
		return instance;
	}	
}
public Data_Weapon(){
	Onload();
}
private int row = 3;//列数
public List<string>list0=new List<string>();//0
public List<string>list1=new List<string>();//1
public List<string>list2=new List<string>();//2
  public string GetName(int id)
{
    return list1[id];
}
  public string GetJJJ(int id)
{
    return list2[id];
}
public void Onload()
 {       StreamReader sr = File.OpenText("Assets/Base/Data_Weapon.txt");
       string lineText;
       lineText=sr.ReadLine();
       string[] lines = File.ReadAllLines("Assets/Base/Data_Weapon.txt");
       while ((lineText = sr.ReadLine()) != null){

        for(int i=0;i<lines.Length;i++)
        {
       string[] lineArray = lines[i].Split('\t');  
             list0.Add(lineArray[0]);
             list1.Add(lineArray[1]);
             list2.Add(lineArray[2]);
        }
}
    
}
    
}
