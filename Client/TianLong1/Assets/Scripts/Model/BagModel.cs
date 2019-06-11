using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagModel  {
    #region base
    private static BagModel singleton;
    public static BagModel Singleton
    {
        get
        {
            return singleton ?? (singleton = new BagModel());
        }
    }
    private BagModel() {
        BagDic.Add(1,new Item("hongbaoshi",50));
        BagDic.Add(16, new Item("lvbaoshi", 750));
        BagGemDic.Add(1, new gem(10));
        BagGemDic.Add(16, new gem(140));
    }
    #endregion
    //背包里的所有物品
    public Dictionary<int, Item> BagDic = new Dictionary<int, Item>();
    //背包里的所有宝石
    public Dictionary<int, gem> BagGemDic = new Dictionary<int, gem>();
   
        }

