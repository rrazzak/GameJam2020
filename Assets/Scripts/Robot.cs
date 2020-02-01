﻿using System.Collections;
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

    void Start()
    {
        limbCnt = 4;   
    }

    void Update()
    {
        
    }

    private void Movement()
    {
        //post condition: movement with WASD, left and right are walking, up is Jump, and Down is to pick up dropped limbs.
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

    private void Death()
    {
        //precondition: limbCnt =< 0

        //postcondition: make isDead true
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

}
