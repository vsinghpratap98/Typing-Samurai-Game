using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player: MonoBehaviour
{
    public List<WordInput> words;

    private const string V = "p";
    public float speed = 10.0f;
    public Rigidbody2D rb;
    public bool isGrounded = false;
    public bool standing;
    public float jumpForce = 10.0f;
    char [] StoreUserInput;
    public string wrod;
    public bool onlyone=true;

    // private playerController controller;    
    public Vector2 maxSpeed = new Vector2(3, 0);
    public Rigidbody2D enemies;


    private Animator animator;
    // private bool bDetectKey;
    //  private KeyCode kCode;




    public char[] StoreUserInput1 { get => StoreUserInput; set => StoreUserInput = value; }

    // Start is called before the first frame update
    void Start()
    {
        // controller = GetComponent<playerController>();
        animator = GetComponent<Animator>();
    }

    public void takeword(string pos){
        this.wrod=pos;
        
            onlyone=true;


    }
    void Update()
    {    
        
        var forceX = 0f;
        // to reset the force each frame
        // weteher thr player is moving faster or not
        var absVelx = Mathf.Abs(rb.velocity.x);
        


        if (wrod=="right")
        {
            if (absVelx < maxSpeed.x)
            {
                forceX = speed;
            }
            transform.localScale = new Vector3(6.405936f, 6.405936f, 6.405936f);
            animator.SetInteger("animState", 1);

        }
        else if (wrod=="left")
        {
            if (absVelx < maxSpeed.x)
            {
                forceX = -speed;
            }
            transform.localScale = new Vector3(-6.405936f, 6.405936f, 6.405936f);
            animator.SetInteger("animState", 1);
        }
        else
        {
            animator.SetInteger("animState", 0);
        }

        rb.AddForce(new Vector2(forceX, 0));
        if (wrod=="jump" && isGrounded)
        {
            rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        }
        if(wrod=="bomb"){
            if(onlyone==true){
            Rigidbody2D clone = Instantiate(enemies, this.transform.position, Quaternion.identity);
            clone.velocity = new Vector2(+2,0);
            onlyone=false;
            }
        }


    }
}
