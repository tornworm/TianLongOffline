using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesT  {

    public static Object Load(string path)
    {
       return  Resources.Load(path);
    }
    public static T Load<T>(string path) where T : Object
    {
        return (T)Resources.Load(path, typeof(T));
    }
    public static Object Load(string path, System.Type systemTypeInstance)
    {
        return Resources.Load(path, typeof(System.Type));
    }
    public static Sprite LoadSprite(string path)
    {
        return Resources.Load(path, typeof(Sprite)) as Sprite;
    }

}

