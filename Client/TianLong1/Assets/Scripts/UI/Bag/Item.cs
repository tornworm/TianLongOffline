using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item { 

    public string name { get; set; }
    public int gold { get; set; }
    public string image { get; set; }

    public Item(string name,int gold)
    {
        this.name = name;
        this.gold = gold;
        image = "Textures/UI/Normal/common_001";
         
    }
}
