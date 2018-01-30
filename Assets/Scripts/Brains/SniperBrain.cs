using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

[CreateAssetMenu]
public class SniperBrain : Brain {

	public FloatReference WaitTime;
	public FloatReference WalkTime;

	Transform player;

	int state = 0;
	float waitStart;

	public override void Think (Pawn pawn)
	{

		switch (state) {
		case 0:
			//walk some
			Vector2 direction = Random.insideUnitCircle;
			pawn.Move (direction);
			waitStart = Time.time;
			state = 1;
			break;
		case 1:
			//wait some
			if ((Time.time - waitStart) > WalkTime.Value)
				state = 2;
			break;
		case 2:
			//Find player position
			if (player == null) {
				GameObject pgo = GameObject.FindWithTag ("Player");
				if (pgo == null) {
					Debug.Log ("Could not find player! Cannot think! -SniperBrain");
					return;
				}
				player = pgo.transform;
			}

			//look player
			pawn.Look (player.position);

			//fire a round
			pawn.Shoot (player.position);

			waitStart = Time.time;
			state = 3;
			break;
		case 3:
			//wait a little
			if ((Time.time - waitStart) > WaitTime.Value)
				//repeat
				state = 0; 
			break;
		}



		return;
	}



}
