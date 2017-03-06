using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime_controller : MonoBehaviour {
    public Vector3 target;
    private Vector2 PlayerDirection;
    private float xdir;
    private float ydir;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        target.x = transform.position.x;
        target.y = transform.position.y;

        PlayerDirection = new Vector2(xdir, ydir);
        transform.Translate(PlayerDirection.normalized * speed);
	}
}
