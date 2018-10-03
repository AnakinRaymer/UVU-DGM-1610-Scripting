using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player;

	//Particles
	public GameObject DeathParticle
	public GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnDelay;

	//Point Penalty
	public int PointPenaltyOnDeath;

	// Store gravity value
	private float GravityStore;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Rigidbody2D> ();
	}
	
	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Generate Death Particle
		Instantiate (DeathParticle, player.transform.position, player.transform.rotation);
		//Hide Player
		player.enabled = false;
		player.GetComponent<Renderer> ().enabled = false;
		// Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().GravityScale;
		Player.GetComponent<Rigidbody2D>().GravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().Velocity = Vector2.zero;
		// Point Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		//Debug Message
		Debug.Log ("Player Respawn");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
