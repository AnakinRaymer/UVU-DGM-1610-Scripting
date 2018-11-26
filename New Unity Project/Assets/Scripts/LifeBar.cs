using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBar : MonoBehaviour {

	public int AddLife;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
			return;
		
		LifeManager.AddPoints (AddLife);

		Destroy (gameObject);
	}
}

