using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System;
/// <summary>
/// 客户端消息管理器
/// </summary>
public class ClientManager : MonoBehaviour {

    #region Socket配置
    //Socket属性
    Socket socket;
    const int BUFFER_SIZE = 1024;
    public byte[] readBuff = new byte[BUFFER_SIZE];
    string ID;
    /// <summary>
    /// 建立和服务器的Socket连接
    /// </summary>
    private void Awake()
    {
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        socket.Connect("10.10.63.153", 1234);
        ID = socket.LocalEndPoint.ToString();
        Debug.Log("连接成功，从服务器接收的本机IP是:" + ID);

        socket.BeginReceive(readBuff, 0, BUFFER_SIZE, SocketFlags.None, RepeatReceive, null);
        DontDestroyOnLoad(this);

    }
    /// <summary>
    /// 每次收到服务器给我们传来的一条消息
    /// </summary>
    /// <param name="ar"></param>
    private void RepeatReceive(IAsyncResult ar)
    {
        try
        {
            int count = socket.EndReceive(ar);
            string str = System.Text.Encoding.UTF8.GetString(readBuff, 0, count);
            NetManager.SMsgList.Add(str);

            socket.BeginReceive(readBuff, 0, BUFFER_SIZE, SocketFlags.None, RepeatReceive, null);
        }
        catch (Exception)
        {

            socket.Close();
        }
    }
    #endregion

    //我们要给服务器发送的所有消息列表，各功能模块对其进行add操作
    public static  List<string> CMsgList = new List<string>();
    /// <summary>
    /// 根据不同的协议号制定不同的协议
    /// </summary>
    /// <param name="ID"></param>
    public string PackCMsg(int ID)
    {
        string msg = null;
        if (ID == 10001)
        {
            //以背包举例
            //添加、删除物品协议
            //格式为：协议号+个人标识号（我是谁）+添加or删除？(0,1)+物品ID+物品变化数量
            // msg=ID+"|"+""+......
            return msg;
        }
        else if (ID == 10002)
        {
            return msg;
        }
        else if (ID == 10003)
        {
            return msg;
        }
        else
        {
            return null;
        }
    }
    /// <summary>
    /// 处理客户端信息
    /// </summary>
    void HandleCMsg()
    {
        //如果消息长度为0，不处理
        if (CMsgList.Count <= 0) return;
        //得到消息列表第一条消息
        string str = CMsgList[0];
        //得到后移除该条消息
        CMsgList.RemoveAt(0);
        //把该条消息转化成字节数组并发送给服务器
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
        socket.Send(bytes);

    }
    /// <summary>
    /// 不断发送消息给服务器
    /// </summary>
    void Update()
    {
        for (int i = 0; i < CMsgList.Count; i++)
        {
            HandleCMsg();
        }
    }
}
