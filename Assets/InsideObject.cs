using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;


[RequireComponent(typeof(SpriteRenderer))]
public class InsideObject : MonoBehaviour {
	public bool DEBUG = false;

	SpriteRenderer sr;

	public FloatReference FadedAlpha;
	public FloatReference NormalAlpha;


	void Awake(){
		sr = GetComponent<SpriteRenderer> ();
		SetAlpha (NormalAlpha.Value);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(DEBUG) Debug.Log ("Entered Trigger");

		if (other.tag == "Player") {
			SetAlpha (FadedAlpha.Value);
		}



	}

	void OnTriggerExit2D(Collider2D other){
	
		if (other.tag == "Player") {
			SetAlpha (NormalAlpha.Value);
		}

	}


	void SetAlpha(float a){
		Color c = sr.color;
		c.a = a;
		sr.color = c;
	}

}
