using UnityEngine;
using System.Collections;

public class destroyONContact : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag("Player")) 
		{
			other.GetComponent<Health> ().Death ();
		}
	}
}
