using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int maxHealth;
	private int health;


	private bool isDead = false;


	void Awake()
	{
		health = maxHealth;
	}

	// Use this for initialization
	public void TakeDamage(int damage)
	{
		if (!isDead)
		maxHealth -= damage;
	}

	public void Death()
	{
		transform.gameObject.SetActive(false);
	}

	void Update() 
	{
		if (health <= 0) 
		{
			isDead = true;
			Death ();		
		}
	}


}
