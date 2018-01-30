using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GunPickup : Pickup {

	public override void OnPickedUp (PickupBehaviour pickup, Pawn pawn)
	{

		pawn.Gun = pickup.GetComponent<GunBehaviour> ();

		pawn.Gun.team = pawn.team;

		pickup.transform.SetParent(pawn.transform); 
		pickup.transform.position = pawn.GunHoldTransform.position;

	}


}
