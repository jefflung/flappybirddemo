using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;

public class Scroller : MonoBehaviour
{
    // creating floating point number that does an offset
    public float offsetFactor; 
    // save the start position
    float startPosX;
    // Use this for initialization 
    void Start ()
    {
        // go to our scroller object and get its position x
        startPosX = transform.parent.position.x;
    }
    // Update is called once per frame 
    void Update ()
    {
        // get the position of the parent and work out how far away we are form the start
        float xPos = transform.parent.position.x - startPosX;
        // how much offset do we apply to the texture
        float texOffset = xPos * offsetFactor;
        // get our material and offset it
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset( "_MainTex", new Vector2( texOffset, 0.0f ) );
    }
}