﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {
	public int[] Eggs = new int[11];

	public string[] Jedi;
	public string[] Pet;

	// Use this for initialization
	void Start () {
	

		Eggs[0] = 1;
		Eggs[1] = 2;
		Eggs[2] = 3;
		Eggs[3] = 4;
		Eggs[4] = 5;
		Eggs[5] = 6;
		Eggs[6] = 7;
		Eggs[7] = 8;
		Eggs[8] = 9;
		Eggs[9] = 10;
		Eggs[10] = 11;
		Eggs[11] = 12;
		
		Jedi= new string[4];

		Jedi[0] = "Obi Wan Kenobi";
		Jedi[1] = "Yoda";
		Jedi[2] = "Mace Windu";
		Jedi[3] = "Kit Fisto";
		Jedi[4] = "Luke Skywalker";

		foreach(string item in Jedi){
			print("Jedi Master " + item);
		}

		Pet = new string [4];

		Pet[0] = "Cats";
		Pet[1] = "Dogs";
		Pet[2] = "Birds";
		Pet[3] = "Rodents";
		Pet[4] = "Reptiles";

		foreach(string item in Pet){
			print ("Former pets " + item);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
