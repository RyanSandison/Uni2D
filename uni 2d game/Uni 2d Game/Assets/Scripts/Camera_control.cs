using UnityEngine;

public class Camera_control : MonoBehaviour {

    public Transform target;
    Camera mycam;
    public float orthoSize = 2f;

	// Use this for initialization
	void Start () {
        mycam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        mycam.orthographicSize = (Screen.height / 100f) / orthoSize;

        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, 0.1f) + new Vector3(0, 0, -1);
        }
	}
}
