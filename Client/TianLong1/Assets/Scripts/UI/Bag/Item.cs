using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{

    public string name { get; set; }
    public int gold { get; set; }
    public string image { get; set; }
    public int count { get; set; }
    public Item(string name, int gold)
    {
        this.name = name;
        this.gold = gold;
        this.count = 1;
        image = "Textures/UI/Normal/common_001";

    }
    public Item(string name, int gold, int count)
    {
        this.name = name;
        this.gold = gold;
        this.count = 1;
        image = "Textures/UI/Normal/common_001";


    }
    public Item() { }
    public Item(string name, int gold, int count, string image)
    {
        this.name = name;
        this.gold = gold;
        this.count = 1;
        this.image = image;
    }
}
