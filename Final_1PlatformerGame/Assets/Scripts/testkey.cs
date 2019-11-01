using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testkey : MonoBehaviour
{
    private bool bDetectKey;
    private KeyCode kCode;  //this stores your custom key

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (bDetectKey)
                bDetectKey = false;
            else
                bDetectKey = true;
        }

        if (bDetectKey)  //this detects the key being pressed and saves it to kCode
            DetectInput();

        if (Input.GetKeyDown(kCode)) //the kCode is then compared like a standard Input.GetKeyDown(KeyCode) boolean
        {
            print("Custom key worked");
        }
    }

    public void DetectInput()
    {
        foreach (KeyCode vkey in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(vkey))
            {
                if (vkey != KeyCode.Return)
                {
                    kCode = vkey; //this saves the key being pressed               
                    bDetectKey = false;
                }
            }
        }
    }
}
