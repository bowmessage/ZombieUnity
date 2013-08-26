using UnityEngine;
using System.Collections;

public class ZombieCollision : MonoBehaviour {
	
	public int health = 100;
	ParticleEmitter bloodMain;
	
	// Use this for initialization
	void Start ()
	{
		bloodMain = transform.Find("BloodSplat").Find("Main").particleEmitter;
	}
	
	void Update()
	{
		if (health <= 0)
			Destroy(this.gameObject);
	}
	
	void OnCollisionEnter(Collision objectCollision)
	{
		
		if(objectCollision.gameObject.tag == "PistolBullet")
		{
			health -= Bullet.pistolBulletDamage;
			Destroy(objectCollision.gameObject);
			makeBlood(objectCollision);
			print ("Zombie hit by bullet");
		}
		else if(objectCollision.gameObject.tag == "SMGBullet")
		{
			health -= Bullet.smgBulletDamage;
			Destroy(objectCollision.gameObject);
			makeBlood(objectCollision);
			print ("Zombie hit by bullet");
		}
	}
	
	void makeBlood(Collision objectCollision)
	{
		bloodMain.transform.position = objectCollision.transform.position;
		bloodMain.Emit();
	}
}
