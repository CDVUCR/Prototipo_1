using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	public Transform followTarget;
	public float velocidadCam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 temp = Vector2.MoveTowards(new Vector2(transform.position.x,transform.position.y),new Vector2(followTarget.position.x,followTarget.position.y),velocidadCam);
		Vector3 nuevaPosicion = new Vector3(temp.x,temp.y,transform.position.z);
		transform.position = nuevaPosicion;

	}
}
