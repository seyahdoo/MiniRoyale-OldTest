using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

[CreateAssetMenu]
public class HealthPickup : Pickup {
	public bool DEBUG = false;

	public FloatReference HealthAmount;

	public override void OnPickedUp (PickupBehaviour pickup, Pawn pawn)
	{
		if (DEBUG) Debug.Log ("You Picked Up a Heath Pickup");

		pawn.pawnHealth.AddHealth (HealthAmount);

		Destroy (pickup.gameObject);
	}

}
