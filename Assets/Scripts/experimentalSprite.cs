using UnityEngine;
using System.Collections;

public class experimentalSprite : MonoBehaviour {

	public Texture2D template;

	public int angle = 30;
	public int incrementAmount = 1;
	public Color color = Color.black;
	public int limit = 100;
	 

	void GetCentre (Texture2D texture, out Vector2 centre)
	{
		float centreX = texture.width / 2;
		float centreY = texture.height / 2;

		centre = new Vector2 (centreX, centreY);
	}

	Vector2 ToVector2(int x, int y) 
	{
		return new Vector2 (x, y);
	}

	void ToCoords(Vector2 vector, out int x, out int y)
	{
		x = (int) vector.x;
		y = (int) vector.y;

	}

	Vector2 MakePointAtAngle(int angle, int amountMove)
	{
		float radianAngle = angle * Mathf.Deg2Rad;
		return new Vector2 (Mathf.Cos (radianAngle), Mathf.Sin (radianAngle)).normalized * amountMove;
	}

	Texture2D MakeSpiral (int angle, int incrementAmount, Color color, int limit, Texture2D texture)
	{
		/*This code's gonna make a spiral outta pixels it'll be great
		 * heres how its gonna go down
		 * first we gonna find the centre
		 * then go a specified amount away from the centre
		 * then turn a specific angle away
		 * this point is the new centre and we do the same again but moving further away
		 * repeat until i say stop 
		 */
		Vector2 currentPlace;
		GetCentre (texture, out currentPlace);

		for (int i = 0; i < limit; i += incrementAmount) 
		{
			texture.SetPixel ((int)currentPlace.x, (int)currentPlace.y, color);
			Debug.Log (currentPlace);
			currentPlace += MakePointAtAngle (angle, i);
		}



		return texture;
	
	
	
	}


	Sprite CreateSprite(Texture2D texture)
	{
		Vector2 centre;
		GetCentre (texture, out centre);
		Rect boundary = new Rect (0, 0, texture.width, texture.height);
		return Sprite.Create (texture, boundary, centre);
	}

	// Use this for initialization
	void Awake () 
	{
		template = MakeSpiral (angle, incrementAmount, color, limit, template);
		template.Apply ();
	}

	void Start() {

	}
	// Update is called once per frame
	void Update () {
	
	}
}
