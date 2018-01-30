using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehaviour : MonoBehaviour {
	public bool DEBUG = false;

	public Pickup pickup;

	//-_-
	void OnTriggerEnter2D(Collider2D other) {
		if(DEBUG) Debug.Log ("Entered Trigger");


		Pawn p = other.GetComponent<Pawn> ();

		if (p == null)
			return;

		pickup.OnPickedUp (this,p);


		//Destroy (this.gameObject);
	}

}
