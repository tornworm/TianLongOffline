using System.Collections.Generic;
using UnityEngine;


public class UI_StoreMain : BaseWindow
{
    public UI_StoreMain() : base("Store/UI_StoreMain")
    {

    }
    

    private GameObject panel1 = null;//购买界面
    private GameObject panel2 = null;//出售界面


    private GameObject tabImg1 = null;//我要购买按钮
    private GameObject tabImg2 = null;//我要出售按钮

    List<GameObject> tabImg = new List<GameObject>();//所有按钮集合
    List<GameObject> panel = new List<GameObject>();//所有界面集合

    public override void Start()
    {
        base.Start();
        panel.Clear();
        panel1 = transform.Find("bg/panel1/purchasePanel").gameObject;
        panel2 = transform.Find("bg/panel1/sellPanel").gameObject;
        panel.Add(panel1);
        panel.Add(panel2);

        tabImg.Clear();
        tabImg1 = transform.Find("bg/panel1/purchaseBtn/high").gameObject;
        tabImg2 = transform.Find("bg/panel1/sellBtn/high").gameObject;
        tabImg.Add(tabImg1);
        tabImg.Add(tabImg2);
        SetTab(1);
    }
    public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
       
        if (eventData.pointerEnter.name == "purchaseBtn")
        {
            SetTab(0);
        }
        else if (eventData.pointerEnter.name == "sellBtn")
        {
            SetTab(1);
        }
        
    }
    private void SetTab(int id)
    {
        for (int i = 0; i < 2; i++)
        {

            if (i == id)
            {

                tabImg[i].SetActive(true);
                panel[i].SetActive(true);
            }
            else
            {
                tabImg[i].SetActive(false);
                panel[i].SetActive(false);

            }
        }
    }
}
