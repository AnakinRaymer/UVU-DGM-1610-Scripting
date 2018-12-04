using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour {
	public static int Ammo;
	public PlayerShoot PlayerShoot;
	public GameObject Player;

	public Text AmmoText;


	// Use this for initialization
	void Start () {

		Ammo = 20;

		PlayerShoot = Player.GetComponent<PlayerShoot>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Ammo < 0){
			Ammo = 0;
		}

		AmmoText.text = " " + Ammo;

		if (Ammo < 0){
			PlayerShoot.Ammunition = true;
		}

		else{
			PlayerShoot.Ammunition = false;
		}
	}

	public static void AddPoints (int PointsToAdd) {
		Ammo += PointsToAdd;
	}
}
