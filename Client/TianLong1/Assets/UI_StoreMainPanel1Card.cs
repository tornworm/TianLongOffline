using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class UI_StoreMainPanel1Card : MonoBehaviour {

    // Use this for initialization
    private int id;//字典中的key值
    private int gold;//字典中的value中gold值
    private string image;//字典中的图片路径
    private Text goldText;
    private  Image iconImage;
 
     
    private void Start()
    {
       
        id = int.Parse(name);
        goldText = transform.Find("gold").GetComponent<Text>();
        iconImage = transform.GetChild(1).GetComponent<Image>();

        gold = BagModel.Singleton.BagGemDic[id].gold;
        image = BagModel.Singleton.BagGemDic[id].image;
        Debug.Log(iconImage+"..."+iconImage.sprite);
        
        iconImage.sprite = ResourcesT.LoadSprite(image)  ;
         
        goldText.text = gold+"";
    }

}
