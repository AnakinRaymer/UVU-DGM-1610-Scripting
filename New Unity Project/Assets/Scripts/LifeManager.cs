using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour {
	public static int Lives;

	Text LifeText;


	// Use this for initialization
	void Start () {
		LifeText = GetComponent<Text>();

		Lives = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Lives < 0)
			Lives = 0;
		LifeText.text = " " + Lives;

		if (Lives < 0)
			KillPlayer = false;

		else (Lives > 0)
			KillPlayer = true;

		
	}

	public static void AddPoints (int PointsToAdd) {
		Lives += PointsToAdd;
	}
}


