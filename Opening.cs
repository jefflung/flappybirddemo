using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opening : MonoBehaviour
{
    public GameObject sidescroller;
    public GameObject cam;
    public GameObject bird;
    public GameObject background;
    public GameObject pipes;
    
    public GameObject hud;
    
    private void Awake()
    {
        sidescroller.SetActive(false);
        cam.SetActive(false);
        bird.SetActive(false);
        background.SetActive(false);
        pipes.SetActive(false);
        
        hud.SetActive(false);
    }

    public void EndOpening()
    {
        sidescroller.SetActive(true);
        cam.SetActive(true);
        bird.SetActive(true);
        background.SetActive(true);
        pipes.SetActive(true);
       
        hud.SetActive(true);
        Destroy(this.gameObject);
    }
}
