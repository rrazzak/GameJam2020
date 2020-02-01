using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limb : MonoBehaviour
{
    public Vector2 limbPos;
    public GameObject limbObj;
    public Rigidbody2D limbRb;

    public int limbNum;

    public Limb(int ln)
    {
        this.limbNum = ln;

        /*
         * 3 = right arm
         * 2 = left arm
         * 1 = right leg
         * 0 = left leg
         */
    }

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        
    }

    private void Toss()
    {
        /* postcondition: 45 degree vector of force spawned limb
         *
         * 1: spawn object
         * 2: apply 45 degree force upwards
         */ 
    }

    private void Spawn()
    {
        //limbNum corrosponds with which limb sprite it will spawn as, see constructor
          

        switch(limbNum)
        {
            case 3:
                //right arm
                break;
            case 2:
                //left arm
                break;
            case 1:
                //right leg
                break;
            case 0:
                //left leg
                break;
        }
    }
}
