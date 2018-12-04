using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour {
	// Shoot variables
	public Transform FirePoint;
	public GameObject Projectile;
	public bool Ammunition;
	
	// Use this for initialization
	void Start () {
		// Projectile = GameObject.Find("Projectile");
		Projectile = Resources.Load("PreFab/Projectile") as GameObject;
		Ammunition = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl) && Ammunition == true)
			Instantiate(Projectile,FirePoint.position, FirePoint.rotation);
	}
}
