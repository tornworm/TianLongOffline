using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager {

    private static StoreManager singleton;
    public static StoreManager Singleton
    {
        get
        {
            return singleton ?? (singleton = new StoreManager());
        }
    }
    private StoreManager() { }


}
