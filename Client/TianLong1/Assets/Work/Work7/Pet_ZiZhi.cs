using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet_ZiZhi : MonoBehaviour {

    public GameObject Pet;
	// Use this for initialization
	void Start () {
       

        for(int i = 0; i < 12; i++)
        {
            GameObject obj = Instantiate(Pet, transform);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
