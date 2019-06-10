using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testShow :MonoBehaviour, IEventListener {
    public void OnEventTrigger(Event _Event)
    {
        Debug.Log(_Event.EventID);
    }

    // Use this for initialization
    void Start () {
        EventController.sInstance.AddListener(this);
	}
	

}
