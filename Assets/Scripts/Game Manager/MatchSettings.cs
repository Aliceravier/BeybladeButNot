using UnityEngine;
using System.Collections;

public class MatchSettings : MonoBehaviour {

	public static MatchSettings Instance;

	public enum mode{Deathmatch, Team_Deathmatch};
	public enum lifeSystem{Time, Stock};

	int numOfPlayers;
	private mode modeSelection;
	private lifeSystem lifeSelection;


	public int GetNumOfPlayers()
	{
		return numOfPlayers;
	}

	public void SetNumOfPlayers(int value)
	{
		numOfPlayers = value;
	}


	// Use this for initialization
	void Awake () 
	{
		if (Instance == null) 
		{
			DontDestroyOnLoad (gameObject);
			Instance = this;
		} 
		else if (Instance != this) 
		{
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
