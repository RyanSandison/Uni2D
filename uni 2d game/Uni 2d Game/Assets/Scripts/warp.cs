using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour
{

    public Transform warpTarget;
    private GameObject Player;
    
    void OnTriggerEnter2D(Collider2D other)
    {
     Player = GameObject.FindWithTag("Player");

        if(Player.tag == "Player")
        {
            Player.transform.position = warpTarget.transform.position;
            Camera.main.transform.position = warpTarget.transform.position;
        }
               
    }
    
}


           