using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopQuiz : MonoBehaviour {

	// Quiz

	public static int ColourRed;
	public static int ColourBlue;
	public static int ColourPurple;

	Text ColorText;

	// Use this for initialization
	void Start () {
		ColorText = GetComponent<Text>();
		
		ColorText = ColourRed;
	}
	
	// Update is called once per frame
	void Update () {
		if(ColourRed + ColourBlue)
		ColourText = 0;

		ColorText.text = " " + ColourPurple;
	}
}
