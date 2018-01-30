using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

public class Bullet : MonoBehaviour {
	public bool DEBUG = false;

	public FloatReference LifeTime;
	public FloatReference Damage;

	public Team ownerTeam;

	void OnEnable(){
		//Destroy or pool yourself after some time
		Invoke("Release",LifeTime.Value);

	}

	void OnTriggerEnter2D(Collider2D other) {
		if(DEBUG) Debug.Log ("Entered Trigger");


		Pawn p = other.GetComponent<Pawn> ();

		if (p == null)
			return;

		if (p.team == ownerTeam)
			return;

		p.pawnHealth.RemoveHealth (Damage);

		Destroy (this.gameObject);
	}


	void Release(){
	
		//TODO POOL POOL POOL POOL POOL POOL POOL POOL POOL POOL POOL POOL
		Destroy (this.gameObject);
	
	}

}
