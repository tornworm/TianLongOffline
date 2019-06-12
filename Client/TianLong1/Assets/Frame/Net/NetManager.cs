using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 服务器消息处理管理器
/// </summary>
public class NetManager:MonoBehaviour  {

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    //服务器给我们发送过来的所有消息列表,由ClientManager对其进行Add操作
     public static List<string> SMsgList = new List<string>();
    /// <summary>
    /// 处理服务器信息
    /// </summary>
    void HandleSMsg()
    {
        //如果消息长度为0，不处理
        if (SMsgList.Count <= 0) return;
        //得到消息列表第一条消息
        string str = SMsgList[0];
        //得到后移除该条消息
        SMsgList.RemoveAt(0);
        //对消息进行切割
        string[] args = str.Split('|');
        //根据消息切割后的第一部分（协议号）来进行不同的处理
        if (args[0] == "10001")
        {
            //TODO
            //for example
            //该条消息为背包数据
            //1.解析该条数据
            //2.将此数据赋值给BagModel背包数据类
            //3.使用消息中心刷新对应界面的UI
        }
        else if (args[0] == "10002")
        {
            //TODO

        }
    }
    
    /// <summary>
    /// 在主线程里不断处理消息
    /// </summary>
    void Update()
    {
        for (int i = 0; i < SMsgList.Count; i++)
        {
            HandleSMsg();
        }

    }
}
