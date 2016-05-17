using UnityEngine;
using System.Collections;

public class RespawnManager : MonoBehaviour {	

	int numOfPlayers;


	void stockRespawn()
	{

	}

	void Awake () 
	{
		numOfPlayers = MatchSettings.Instance.GetNumOfPlayers ();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
