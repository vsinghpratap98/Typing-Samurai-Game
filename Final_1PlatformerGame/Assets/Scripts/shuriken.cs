using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuriken : MonoBehaviour
{
    public Rigidbody2D enemies;
    [SerializeField] Transform[] pos;
    void Start()
    {   
    //    StartCoroutine(DoCheck());
       InvokeRepeating ("inst", 0f, 5f);
    }
    public void inst()
    {   print("INSide isnt---");
        Vector2 speed = new Vector2(1, 0);
        int r = Random.Range(0, pos.Length);
        Vector2 position = pos[r].position;
        print("POsition & r"+position+"---"+r);
        Rigidbody2D clone = Instantiate(enemies, position, transform.rotation);
        clone.velocity = new Vector2(-2,0);
    }
    
    // IEnumerator DoCheck()
    // {   
    //     for (int i = 0; i < 5; i++)
    //     {
    //         inst();
    //         yield return new WaitForSeconds(.05f);
    //     }
    // }
}

