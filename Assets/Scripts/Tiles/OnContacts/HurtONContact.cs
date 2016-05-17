using UnityEngine;
using System.Collections;

public class HurtONContact : MonoBehaviour {
	public int damage;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player")) 
		{
			other.GetComponent<Health> ().TakeDamage (damage);
		}
	}


	
}
