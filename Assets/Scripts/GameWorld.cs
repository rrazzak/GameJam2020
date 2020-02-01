using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWorld : MonoBehaviour
{
    public float battery;
    public Text batteryText;
    public Robot robot;

    void Start()
    {
        battery = 100f;
        Restart();
        Pause();
    }

    void Update()
    {
        burnBattery();
    }

    public void changeCharge(float charge)
    {
        battery += charge;
    }

    public void burnBattery()
    {
        battery-= Time.deltaTime;     
        batteryText.text = battery.ToString("#.0");
    }

    public void Restart()
    {
        if(robot.isDead)
        {
            //restart game, return player to level start and set timer and limbCnt to starting values
        }
    }

    public void Pause()
    {
        if(robot.clickedPause)
        {
            /*
             * stop player movement and movement of enemies (if there are any),
             * and stop the battery timer,
             * and stop the movement of any tossed limbs
             * 
             * enter pause menu
             */ 
        }
    }
}
