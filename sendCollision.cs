using UnityEngine;
using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityOSC;

public class sendCollision : MonoBehaviour
{


    private OSCServer myServer;

    public string outIP = "127.0.0.1";
    public int outPort = 4559;
    //public int inPort = 9998;
    // Buffer size of the application (stores 100 messages from different servers)
    public int bufferSize = 100;


    // Start is called before the first frame update
    void Start()
    {
        // init OSC
        OSCHandler.Instance.Init();

        // Initialize OSC clients (transmitters)
        OSCHandler.Instance.CreateClient("myClient", IPAddress.Parse(outIP), outPort);

        // Initialize OSC servers (listeners)
        //myServer = OSCHandler.Instance.CreateServer("myServer", inPort);
        //// Set buffer size (bytes) of the server (default 1024)
        //myServer.ReceiveBufferSize = 1024;
        //// Set the sleeping time of the thread (default 10)
        //myServer.SleepMilliseconds = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //OSCHandler.Instance.SendMessageToClient("myClient", "/1/fader1", randVal);
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log(collision.transform.name + "Has Collided with me!");

        OSCHandler.Instance.SendMessageToClient("myClient", "sonicpi/unity/trigger", "Crash");
    }

    // Process OSC message
    //private void receivedOSC(OSCPacket pckt)
    //{
    //    if (pckt == null) { Debug.Log("Empty packet"); return; }

    //    // Origin
    //    int serverPort = pckt.server.ServerPort;

    //    // Address
    //    string address = pckt.Address.Substring(1);

    //    // Data at index 0
    //    string data0 = pckt.Data.Count != 0 ? pckt.Data[0].ToString() : "null";

    //    // Print out messages
    //    Debug.Log("Input port: " + serverPort.ToString() + "\nAddress: " + address + "\nData [0]: " + data0);
    //}

}
