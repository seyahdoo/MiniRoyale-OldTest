using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

[CreateAssetMenu]
public class Gun : ScriptableObject {

	public GameObject bulletPrefab;

	public FloatReference BulletSpeed;

	/// <summary>
	/// Shoot a bullet from gun point!
	/// </summary>
	public void Shoot(GunBehaviour gunBehaviour){

		//TODO Do this with new POOL!!!! POOL POOL POOL 
		//Get a bullet
		GameObject bullet = Instantiate(bulletPrefab);

		Bullet b = bullet.GetComponent<Bullet> ();
		b.ownerTeam = gunBehaviour.team;

		//Get rigid bullet
		Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();

	
		//SHOOT with transform info
		bullet.transform.position = gunBehaviour.GunBulletPoint.position;
		bullet.transform.rotation = gunBehaviour.GunBulletPoint.rotation;

		rigid.velocity = gunBehaviour.GunBulletPoint.right * BulletSpeed.Value;

	}



}
