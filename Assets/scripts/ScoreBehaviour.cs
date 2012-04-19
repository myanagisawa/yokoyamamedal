using UnityEngine;
using System.Collections;

public class ScoreBehaviour : MonoBehaviour {
	public static int Score = 0;
	
	// Use this for initialization
	void Start () {
		Score = 30;
		guiText.text = "SCORE: " + Score.ToString();
	}
	
	void Update() {
		guiText.text = "SCORE: " + Score.ToString();
	}
}
