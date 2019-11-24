﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + "Has Entered Trigger!");
        OSCHandler.Instance.SendMessageToClient("myClient", "sonicpi/unity/trigger", "Loopy");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + "Has Exited Trigger!");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name + "is in the Trigger!");
    }

}
