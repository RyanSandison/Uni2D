using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime_Move : MonoBehaviour {

    public float moveSpeed;
    public float idleTime;
    public float moveTime;

    private Vector3 dir;
    private Rigidbody2D rBody;
    private bool isMoving;
    private float idleTimeCounter;
    private float moveTimeCounter;

	// Use this for initialization
	void Start () {

        rBody = GetComponent<Rigidbody2D>();

        idleTimeCounter = idleTime;
        moveTimeCounter = moveTime;
	}
	
	// Update is called once per frame
	void Update () {

        if (isMoving)
        {
            moveTimeCounter -= Time.deltaTime;
            rBody.velocity = dir;

            if(moveTimeCounter < 0)
            {
                isMoving = false;
                idleTimeCounter = idleTime;
            }
        }
        else
        {
            idleTimeCounter -= Time.deltaTime;
            rBody.velocity = Vector2.zero;

            if(idleTimeCounter < 0f)
            {
                isMoving = true;
                moveTimeCounter = moveTime;

                dir = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed);
            }
        }

	}
}
