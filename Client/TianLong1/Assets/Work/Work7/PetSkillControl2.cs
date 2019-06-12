using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PetSkillControl2 : BaseWindow
{
    public PetSkillControl2() : base("Example/UI_Example")
    {

    }


    private Text tabText1 = null;
    private Text tabText2 = null;
    private Text tabText3 = null;
    private Text tabText4 = null;

    private GameObject panel1 = null;
    private GameObject panel2 = null;
    private GameObject panel3 = null;
    private GameObject panel4 = null;

    private GameObject tabImg1 = null;
    private GameObject tabImg2 = null;
    private GameObject tabImg3 = null;
    private GameObject tabImg4 = null;

    List<Text> tabTxt = new List<Text>();
    List<GameObject> tabImg = new List<GameObject>();
    List<GameObject> panel = new List<GameObject>();

    // Use this for initialization
    public override void Start () {
      

        tabTxt.Clear();
        tabText1 = transform.Find("bg/panel1/UI_PetMainValue2/TOP/xilian/Text").GetComponent<Text>();
        tabText2 = transform.Find("bg/panel1/UI_PetMainValue2/TOP/hechong/Text").GetComponent<Text>();
        tabText3 = transform.Find("bg/panel1/UI_PetMainValue2/TOP/Learn/Text").GetComponent<Text>();
        tabText4 = transform.Find("bg/panel1/UI_PetMainValue2/TOP/zhenshou/Text").GetComponent<Text>();
        tabTxt.Add(tabText1);
        tabTxt.Add(tabText2);
        tabTxt.Add(tabText3);
        tabTxt.Add(tabText4);

        tabImg.Clear();
        tabImg1 = transform.Find("bg/panel1/UI_PetMainValue2/TOP/xilian/xilian").gameObject;
        tabImg2 = transform.Find("bg/panel1/UI_PetMainValue2/TOP/hechong/hechong").gameObject;
        tabImg3 = transform.Find("bg/panel1/UI_PetMainValue2/TOP/Learn/Learn").gameObject;
        tabImg4 = transform.Find("bg/panel1/UI_PetMainValue2/TOP/zhenshou/zhenshou").gameObject;
        tabImg.Add(tabImg1);
        tabImg.Add(tabImg2);
        tabImg.Add(tabImg3);
        tabImg.Add(tabImg4);

        panel.Clear();
        panel1 = transform.Find("bg/panel1/UI_PetMainValue2/UI_PetMainValue2_1").gameObject;
        panel2 = transform.Find("bg/panel1/UI_PetMainValue2/UI_PetMainValue2_2").gameObject;
        panel3 = transform.Find("bg/panel1/UI_PetMainValue2/UI_PetMainValue2_3").gameObject;
        panel4 = transform.Find("bg/panel1/UI_PetMainValue2/UI_PetMainValue2_4").gameObject;
        panel.Add(panel1);
        panel.Add(panel2);
        panel.Add(panel3);
        panel.Add(panel4);

        SetTab(0);


    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        if (eventData.pointerEnter.name == "xilian")
        { 
            SetTab(0);
        }
        else if (eventData.pointerEnter.name == "hechong")
        { 
            SetTab(1);
        }
        else if (eventData.pointerEnter.name == "Learn")
        { 
            SetTab(2);
        }
        else if (eventData.pointerEnter.name == "zhenshou")
        {
            Debug.Log("444");
            SetTab(3);
        }
    }
    private void SetTab(int id)
    {
        for (int i = 0; i < 4; i++)
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
