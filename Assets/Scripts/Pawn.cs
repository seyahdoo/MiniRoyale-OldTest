using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

[RequireComponent(typeof(Rigidbody2D))]
public class Pawn : MonoBehaviour {

	public bool DEBUG = false;

	private Rigidbody2D body;

	public Brain brain;

	public FloatReference Speed;

	public Transform GunHoldTransform;

	public GunBehaviour Gun;

	public PawnHealth pawnHealth;
	//public float CurrentHealth;

	public Team team;
		
	void Awake(){

		body = GetComponent<Rigidbody2D> ();
	
	}

	void Update(){
	
		if (brain) {
			brain.Think (this);
		}



	}

	public void Move(Vector2 Direction){
		if (DEBUG) Debug.Log ("I am trying to move: " + Direction);

		body.velocity = Direction * Speed.Value * Time.deltaTime;
	
	}

	public void Look(Vector3 Target){
		if (Gun) {
			//Hold and Point Gun!
			Gun.transform.LookAt(Target,-Vector3.forward);

		}
	
	}

	public void Shoot(Vector2 Target){
		if (DEBUG) Debug.Log ("I am trying to shoot at: " + Target);

		//Shoot The Gun
		if (Gun) {
			Gun.Shoot ();
		}

	}




}
