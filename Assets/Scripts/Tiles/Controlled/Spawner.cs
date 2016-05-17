using UnityEngine;
using System.IO;
using System.Collections;

public class Spawner : MonoBehaviour {


	public void RespawnPlayer(GameObject player, Vector2 dist, int speed)
	{
		string selector = player.GetComponent<PlayerController> ().dash;
		Vector2 trueDist = (Vector2) transform.position + dist;

		if (Input.GetButton (selector)) 
		{
			player.transform.position = trueDist;
			player.SetActive (true);
		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
