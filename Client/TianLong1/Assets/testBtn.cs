using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testBtn :MonoBehaviour{
   
	void Start()
    {
        GetComponent<Button>().onClick.AddListener(SendMessage);
    }

    void SendMessage()
    {
        Event a = new Event();
        a.EventID = 222;
        EventController.sInstance.PushEvent(a);
    }
	
}
