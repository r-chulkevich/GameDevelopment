using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float speed = 0.1f;
    Camera mycam;

	void Start () {
        mycam = GetComponent<Camera>();
	}
	
	void Update () {

        mycam.orthographicSize = (Screen.height/100f) / 3f;
        if (target) {
            transform.position = Vector3.Lerp(transform.position, target.position, speed) + new Vector3(0, 0, -10);
        }
	
	}
}