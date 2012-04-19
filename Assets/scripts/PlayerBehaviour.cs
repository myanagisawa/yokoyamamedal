using UnityEngine;
using System.Collections;


public class PlayerBehaviour : MonoBehaviour {

	public Transform prefab = null;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Vector3 ofs = new Vector3(x:Mathf.Sin(Time.fixedTime * 7), y:0, z:0);
			Instantiate(prefab, transform.position+ofs , transform.rotation);
			ScoreBehaviour.Score -= 1;
		}
	}
}
