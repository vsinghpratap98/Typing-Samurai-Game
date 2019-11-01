using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public string[ ] commands = new string[ ]{"jump", "right", "left", "bomb"} ;
    public player howdy;
    public string wordinput;
    public int delay = 0;


    // Update is called once per frame
    void Update()
    {
        
        if (delay > 100){
            delay = 0;
            wordinput = "";

        }
        if(Input.inputString.Length == 0){
            delay += 1;
        }
      foreach (char letter in Input.inputString)
		{
            wordinput += letter;
            print(wordinput);
            howdy.takeword(wordinput);
	    } 
        // if(wordinput=="jump"){
            

        // }
        // if(wordinput=="right"){
            
        // }
        // if(wordinput=="left"){
            
        // }
        // if(wordinput=="bomb"){
            
        // }
    }
}
