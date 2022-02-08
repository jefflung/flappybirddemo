using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPipe : MonoBehaviour
{
    public AudioSource powerSound;
    public AudioSource explodeSound;
    void OnCollisionEnter2D( Collision2D collision )
    {
        if ( collision.gameObject.tag == "score")
        {
            gameObject.SetActive(false);
            transform.parent.Find("Pipes0").gameObject.SetActive(false);
            powerSound.Play();
            transform.parent.Find("Explosion").gameObject.SetActive(true);
            explodeSound.Play();
        }
    }
}
