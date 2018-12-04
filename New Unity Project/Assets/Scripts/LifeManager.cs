using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {
	public static int Lives;
	public GameObject Player;
	public KillPlayer Killplayer;
	Text LifeText;


	// Use this for initialization
	void Start () {
		LifeText = GetComponent<Text>();
		Killplayer = Player.GetComponent<KillPlayer>();
		Lives = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Lives < 0)
			Lives = 0;
		LifeText.text = " " + Lives;

		if (Lives < 0)
			Killplayer.isAlive = false;

		else
			Killplayer.isAlive = true;

		
	}

	public static void AddPoints (int PointsToAdd) {
		Lives += PointsToAdd;
	}
}


