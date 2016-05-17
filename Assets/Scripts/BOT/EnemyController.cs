using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	Rigidbody2D rb2D;
	Transform playerPos;

	public float timer;
	private float timerStore;
	private Vector2 relativePos;

	public float speed;


	// Use this for initialization
	void Awake () 
	{
		playerPos = GameObject.Find ("Player").transform;
		rb2D = GetComponent<Rigidbody2D> ();
		timerStore = timer;

	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		relativePos = (playerPos.position - transform.position).normalized;
		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			rb2D.AddForce (relativePos * speed);
			timer = timerStore;
		}
		
	}
}
