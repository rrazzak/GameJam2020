using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIHandler : MonoBehaviour
{
    public Robot robot;
    public GameWorld gw;

    private float batteryBar;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.BeginGroup(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 300, 600, 600));

        /*
         * pause menu, title screen with buttons to go to menu, close game, or start game.
         * I dont think we can impliment saving in the time we have
         * 
         */
        GUI.EndGroup();
    }

    private void GoToTitle()
    {
        if (robot.isDead)
            SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
    }

    private void GoToGame()
    {
        SceneManager.LoadScene("GameWorld", LoadSceneMode.Single);
    }
}
