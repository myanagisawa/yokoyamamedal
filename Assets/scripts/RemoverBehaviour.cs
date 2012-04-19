using UnityEngine;
using System.Collections;

public class RemoverBehaviour : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	}
}
