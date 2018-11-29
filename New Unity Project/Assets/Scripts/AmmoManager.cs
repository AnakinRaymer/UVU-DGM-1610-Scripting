﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour {
	public static int Ammo;
	public PlayerShoot PlayerShoot;

	Text AmmoText;


	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();

		Ammo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Ammo < 0)
			Ammo = 0;
		AmmoText.text = " " + Ammo;

		if (Ammo < 0)
			PlayerShoot.Ammunition = true;

		else (Ammo > 0)
			PlayerShoot.Ammunition = false;
	}

	public static void AddPoints (int PointsToAdd) {
		Ammo += PointsToAdd;
	}
}
