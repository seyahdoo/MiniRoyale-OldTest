using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

[CreateAssetMenu]
public class PawnHealth : ScriptableObject {

	public FloatReference MaximumHealth;

	public float CurrentHealth;

	public void AddHealth(float amount){
		CurrentHealth += amount;

		if (CurrentHealth > MaximumHealth) {
			CurrentHealth = MaximumHealth;
		}

		if (OnPawnHealthChanged != null) OnPawnHealthChanged (this);
	}

	public void RemoveHealth(float amount){
		CurrentHealth -= amount;

		if (CurrentHealth < 0) {
			CurrentHealth = 0;
			if (OnPawnDead != null) OnPawnDead (this);
		}
		
		if (OnPawnHealthChanged != null) OnPawnHealthChanged (this);
	}

	public delegate void PawnHeathEvent(PawnHealth pawnHealth);

	public event PawnHeathEvent OnPawnHealthChanged;
	public event PawnHeathEvent OnPawnDead;

}
