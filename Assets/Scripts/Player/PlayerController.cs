using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 10;
	public float chargeupSpeed = 1;
	private float normalSpeed;

	SpriteRenderer spriteColour;
	Color defaultColour;

	public float chargeSpeed;
	public float chargeLimit;
	private float timer = 0.1f;

	private float moveHorizontal;
	private float moveVertical;

	private Vector2 movement;

	public string horizontal = "Horizontal_P1";
	public string vertical = "Vertical_P1";
	public string dash = "Jump_P1";
		


	Rigidbody2D rb2D;
	// Use this for initialization
	void Awake () 
	{
		rb2D = GetComponent<Rigidbody2D> ();
		spriteColour = GetComponent<SpriteRenderer> ();
		defaultColour = spriteColour.color;
		normalSpeed = speed;
	}
	
	// Update is called once per frame

	void ChargeUp()
	{
		speed = chargeupSpeed;
		if (timer < chargeLimit)
			timer += Time.deltaTime;
		spriteColour.color = Color.Lerp (spriteColour.color, Color.yellow, timer * 0.01f);
	}

	void Dash()
	{
		rb2D.AddForce (movement.normalized * timer * chargeSpeed);
		timer = 0.1f;
	}
	void Update() 
	{
		if (Input.GetButton (dash)) 
		{
			ChargeUp ();

		} 
		else if (Input.GetButtonUp (dash))
		{
			Dash ();
		} 
		else 
		{
			speed = normalSpeed;
			spriteColour.color = defaultColour;
		}
	}
	void FixedUpdate () 
	{
		moveHorizontal = Input.GetAxis (horizontal);
		moveVertical = Input.GetAxis (vertical);

		movement = new Vector2 (moveHorizontal, moveVertical);

		rb2D.AddForce (movement * speed);

	}
}
