using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBar : MonoBehaviour {

	public int AddAmmo;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
			return;
		
		AmmoManager.AddPoints (AddAmmo);

		Destroy (gameObject);
	}
}

