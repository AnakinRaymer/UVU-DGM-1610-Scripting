using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int num;
	public string Name;

	// Use this for initialization
	void Start () {
		if(num == 10){
			print("Hurray you picked ten!");
		}
		
		switch(num){
			case 1:
				print("You picked " + num);
				break;

			case 3:
				print("You picked " + num);
				break;

			case 6:
				print("You picked " + num);
				break;

			case 10:
				print("You picked " + num);
				break;

			default:
				print("I dont understand " + num);
				break;
				}

		switch(Name){
			case "Jason":
				print("Welcome to camp crystal lake " + Name + " - love mother");
			break;

			case "Michael":
				print("Welcome to Haddonfield " + Name);
			break;

			case "Freddie":
				print("Welcome to Elm Street " + Name);
			break;

			case "Leatherface":
				print("The stars and stripes are big at night... Deep in the heart of Texas");
			break;

			default:
				print("I dont know " + Name);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
