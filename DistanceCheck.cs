using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCheck : MonoBehaviour
{
    public GameObject player;
    public GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
        // find our cube with the tag player and store it as a variable
        player = GameObject.FindGameObjectWithTag("Scroller");
        pipe = GameObject.FindGameObjectWithTag("Pipe");
    }

    void GetDistanceToPlayer()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        
        //Debug.Log(distance);
        if(distance > 20)
        {
            Debug.Log("Pipes start loop");
            transform.position = new Vector3(player.transform.position.x + 1, player.transform.position.y, player.transform.position.z);
            pipe.transform.position = new Vector3(pipe.transform.position.x + Random.Range(-0.5f, 0.5f),pipe.transform.position.y + Random.Range(-2.0f, 2.0f), pipe.transform.position.z);
            transform.Find("Capsule").gameObject.SetActive(true);
            transform.Find("Pipes0").gameObject.SetActive(true);
            transform.Find("Explosion").gameObject.SetActive(false);
            Debug.Log(pipe.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetDistanceToPlayer();
    }
}
