using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour {

	public GameObject winText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Player") {
			winText.SetActive (true);
			StartCoroutine (wait ());
		}
	}

	IEnumerator wait() {
		
		yield return new WaitForSeconds (5);
	}
}
