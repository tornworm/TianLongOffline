using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagManager : BaseManager
{

    private volatile static BagManager singleton;
    public static BagManager Singleton
    {
        get { return singleton ?? (singleton = new BagManager()); }
    }
    private BagManager() { }
    /// <summary>
    /// 向背包内添加一个物品
    /// </summary>
    /// <param name="ID"></param>
    /// <param name="name"></param>
    /// <param name="gold"></param>
    public void AddItem(int ID,string name,int gold)
    {
        BagModel.Singleton.BagDic.Add(ID, new Item(name, gold));
    }
    public void AddItem(int ID, string name, int gold,int count)
    {
        BagModel.Singleton.BagDic.Add(ID, new Item(name, gold,count));
    }
    public void RemoveItem(int ID, string name, int gold)
    {
        if (!BagModel.Singleton.BagDic.ContainsKey(ID)) return;
        if (BagModel.Singleton.BagDic[ID].count <= 0) return;
        BagModel.Singleton.BagDic[ID].count--;
        if (BagModel.Singleton.BagDic[ID].count <= 0) BagModel.Singleton.BagDic.Remove(ID);
    }
    public void RemoveItem(int ID, string name, int gold, int count)
    {
        if (!BagModel.Singleton.BagDic.ContainsKey(ID)) return;
        if (BagModel.Singleton.BagDic[ID].count-count <= 0) return;
        BagModel.Singleton.BagDic[ID].count-=count;
        if (BagModel.Singleton.BagDic[ID].count <= 0) BagModel.Singleton.BagDic.Remove(ID);
    }
}
