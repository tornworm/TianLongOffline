using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet_ZiZhi : MonoBehaviour {

    private GameObject Pet;
	// Use this for initialization
	void Start () {

        Pet = Resources.Load("Prefabs/UI/PetSkill/Pet_ZIZHI") as GameObject;
        for(int i = 0; i < 12; i++)
        {
            GameObject obj = Instantiate(Pet, transform);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
