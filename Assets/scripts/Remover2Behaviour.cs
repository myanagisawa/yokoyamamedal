using UnityEngine;
using System.Collections;

public class Remover2Behaviour : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		ScoreBehaviour.Score += 3;
	}
}
