using UnityEngine;
using System.Collections;

public class PusherBehaviour : MonoBehaviour {
	
	private Vector3 origin;
	
	// Use this for initialization
	void Start () {
		origin = rigidbody.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 ofs = new Vector3 (x:0, y:0, z:((Mathf.Sin(Time.fixedTime) * 2) / 3));
		rigidbody.MovePosition(origin+ofs);
	}
}
