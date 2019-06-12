using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem : Item {



    public int level { get; set; }
	public gem(int level):base("1",1)
    {
        this.level = level;
        name = "1";
        gold = 1;
    }
    public gem(int level,string name,int gold)
    {
        this.level = level;
        this.name = name;
        this.gold = gold;
    }
}
