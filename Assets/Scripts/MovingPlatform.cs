using UnityEngine;
using System.Collections;
//script for moving platforms

public class MovingPlatform : MonoBehaviour
{
    public float move = 3;
    private Vector3 startPos;
    public float dirPath;
    public float dis;
    public string axis;
    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    //this method will help determine what direction the platforms move in, whether its the x y or z axis
    void FixedUpdate()
    {
        if (axis == "x")
        {
            transform.position = new Vector3(dirPath * Mathf.PingPong(Time.time * move, dis) + startPos.x, transform.position.y, transform.position.z);
        }

        else if (axis == "y")
        {
            transform.position = new Vector3(transform.position.x, dirPath * Mathf.PingPong(Time.time * move, dis) + startPos.y, transform.position.z);
        }

        else if (axis == "z")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, dirPath * Mathf.PingPong(Time.time * move, dis) + startPos.z);
        }

    }
}