using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public Vector2 robotPos;
    public GameObject robotObj;
    public Rigidbody2D robotRb;

    public int limbCnt;
    public bool isDead;
    public bool clickedPause;
    public bool running;
    public bool facingLeft;
    public float speed = 500f;
    public float jumpSpeed = 20f;
    public float preY;
    public float postY;

    void Start()
    {
        limbCnt = 4;   
        robotRb = gameObject.GetComponent<Rigidbody2D>();
        robotPos= transform.position;
    }

    void FixedUpdate()
    {
        Movement();
        facingLeft = false;
    }

    private void Movement()
    {
        preY = transform.position.y;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0.0f, 0.0f);
            running = true;
            facingLeft = true;
            Flip();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            running = true;
            facingLeft = false;
            Flip();
        }
        else
        {
            running = false;
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (Mathf.Abs(preY - postY) < 0.2)
            {
                transform.position += Vector3.up * jumpSpeed * Time.deltaTime;
            }
        }
        robotPos = transform.position;
        postY = transform.position.y;
    }

    private void Detach()
    {
        //precondition: -1 < limbCnt

        /*  postcondition: limbCnt=limbCnt-1, Limb object is spawned according to the limb count,
         *     3= rightarm, 2=leftarm, 1=rightleg, 0=leftleg,
         *     robot appears as appropriate sprite
         */
    }

    private void Attach()
    {
        //precondition: limbCnt < 4, limb is near

        /* post condition: limbCnt=limbCnt+1, robot appears as appropriate sprite
         * nearby limbs are reattached
         * 
         * note: if you detach two arms and a leg, then attach an arm, it will come back as a leg. we might want to adjust that if we have time.
         */
    }

    private void TakeDamage()
    {
        //postcondition: run Detach
        //if limbCnt <= -1, run Dead;
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "danger")
        {
            TakeDamage();
        }

        if(other.gameObject.tag == "limb")
        {
            //if "down key"
            //attach
        }
    }


    private void Flip()
    {
        Vector3 theScale = transform.localScale;
        if (facingLeft == true)
        {
            theScale.x = -3;//-transform.localScale.x;
            transform.localScale = theScale;
        }
        if (facingLeft == false)
        {
            theScale.x = 3;// Mathf.Abs(transform.localScale.x);
            transform.localScale = theScale;
        }
    }

}
