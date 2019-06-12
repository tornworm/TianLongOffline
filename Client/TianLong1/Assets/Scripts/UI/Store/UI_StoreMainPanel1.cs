using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 显示商会-我要出售界面的信息
/// </summary>
public class UI_StoreMainPanel1 : MonoBehaviour {

    public GameObject card;
	// Use this for initialization
	void Start () {
        foreach (var item in BagModel.Singleton.BagGemDic)
        {
           
          GameObject tmpCard=  Instantiate(card);
            tmpCard.transform.parent = card.transform.parent;
            tmpCard.SetActive(true);
            tmpCard.name = item.Key.ToString();

        }
	}
	
	
}
