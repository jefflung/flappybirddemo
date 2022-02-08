using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdBehaviour : MonoBehaviour
{
    // gravity bring are ugly bird down
    public float gravity; 
    public float clickImpluse;
    public Sprite flapUpSprite, flapDownSprite, flapMidSprite;

    // track the speed of moving up and down
    float ySpeed; 
    //variables to track our position
    float posX, posY, posZ;
    int animCount = 0;
    int score = 0;

    public AudioSource flapSound;
    public AudioSource hitSound;
    public AudioSource scoreSound;
    public Text scoreText;

    

    void Start()
    {
        // get our position and put into variables
        posX = transform.position.x; 
        posY = transform.position.y; 
        posZ = transform.position.z; 
        // yspeed to zero
        ySpeed = 0.0f;
        
    }

   
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            flap(); // animation 
        }
        animCount = animCount + 1; 
        if(ySpeed <= 0)
        {
            animCount = 2;
        }
        if (animCount == 4)
        {
            animCount = 0;    
        }
        if (animCount == 1)
        {
            GetComponent<SpriteRenderer>().sprite = flapUpSprite;
        }
        else if (animCount == 3)
        {
            GetComponent<SpriteRenderer>().sprite = flapDownSprite;
        }
        else 
        {
            GetComponent<SpriteRenderer>().sprite = flapMidSprite;
        }
        float angle = 9.0f * ySpeed; 
        if (angle > 30.0f) 
            angle = 30.0f; 
        if (angle < -30.0f) 
            angle = -30.0f;
        transform.rotation = Quaternion.Euler(0, 0, angle);
        scoreText.text = score.ToString();
        
    }
    void FixedUpdate()
    {
        ySpeed -= gravity * Time.fixedDeltaTime; 
        posY += ySpeed * Time.fixedDeltaTime;
        transform.localPosition = new Vector3(posX, posY, posZ);
    }
    void flap()
    {
        ySpeed = clickImpluse;
        flapSound.Play();
    }
    void OnTriggerEnter2D(Collider2D coll)
    {   
        if(coll.gameObject.tag == "score")
        {
            scoreSound.Play();
            score += 1;
        }
        else
        {
            transform.parent.GetComponent<SideScroller>().xSpeed = 0;
            transform.parent.Find("gameover").gameObject.SetActive(true);
            hitSound.Play();
            this.gameObject.SetActive(false);
        }
    }
    
}