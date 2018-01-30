using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Brain for player controller
/// </summary>
[CreateAssetMenu]
public class PlayerBrain : Brain {


	public override void Think(Pawn pawn){
	
		pawn.Move (new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical")));

		pawn.Look (Camera.main.ScreenToWorldPoint (Input.mousePosition));
		//Gun.transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition),-Vector3.forward);


		//TODO not screen pixel position, scene ray position...
		if (Input.GetButtonDown ("Fire1")) {
			pawn.Shoot ((Vector2)Input.mousePosition);
		}


	}

}
