using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stupid brain.
/// Will shoot and move complately random.
/// </summary>
[CreateAssetMenu]
public class StupidBrain : Brain {



	public override void Think(Pawn pawn){
	
		pawn.Move (new Vector2 (Random.Range (-1f, 1f), Random.Range (-1f, 1f)));
		pawn.Shoot (new Vector2 (Random.Range (float.MinValue, float.MaxValue), Random.Range (float.MinValue, float.MaxValue)));
	
	}


}
