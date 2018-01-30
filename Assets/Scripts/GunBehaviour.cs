using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviour : MonoBehaviour {

	public bool DEBUG = false;

	public Gun gun;

	public Transform GunHolster;
	public Transform GunBulletPoint;

	public Team team;

	public void Shoot(){
		
		gun.Shoot (this);
	
	}

	void Update(){
		if (DEBUG) {
			if (Input.GetButtonDown ("Fire1")) {
				Shoot ();
			}
		}
	
	}


}
