using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
using UnityEngine.UI ;

public class dESTROYsHURIKEN : MonoBehaviour
{
    public int count=0;
    public scorescript ss;

    void Update(){
        if(transform.position.x<-6){
           ss.scoreValue+=10;
           Destroy(this); 
        }
    }
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player" || other.collider.tag == "Ground")
        {
            
            Destroy(gameObject);
            if(count==3){
                SceneManager.LoadScene("Scene2");
                count=0;
            }
            count++;
        }
    }
}
