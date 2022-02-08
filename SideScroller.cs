using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScroller : MonoBehaviour
{
    // create a floating point number and make it available in our insepctor
    public float xSpeed; 
    // 3 floating point numbers, but keep them private
    float posX, posY, posZ;

    //This happens before the first image on the screen appears
    void Start ()
    {
        // getting our variables and we are setting to our transform . position
        posX = transform.position.x; 
        posY = transform.position.y; 
        posZ = transform.position.z;
    }
    // called at a fixed rate
    void FixedUpdate()
    {
        // get the current time multiplied by our speed variable
        posX += Time.fixedDeltaTime * xSpeed;
        // set our x position to a new position
        transform.position = new Vector3(posX, posY, posZ);
    }
}