using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public abstract class BaseWindow : MonoBehaviour,IPointerClickHandler,IBaseUI
{

    //窗口预制体所存在的路径
    string path;
    //所有页面集合
   // public List<GameObject> panelList = new List<GameObject>();
    private BaseWindow() { }
    //构造普通界面
    public BaseWindow(string path)
    {
        this.path = path;
    }
  
    //构造标准界面
    public BaseWindow(string path,int panelCount)
    {
        this.path = path;
    }



    public virtual void Awake()
    {

    }
    public virtual void Start()
    {
       
    }
    public virtual void OnEabled()
    {

    }
    public virtual void OnDestory()
    {

    }
    public virtual void Update()
    {

    }

    public virtual void OnPointerClick(PointerEventData eventData)
    {
       
    }

    public void GetGlobalMsg()
    {
        Debug.Log("接收到广播消息!");
    }
}
