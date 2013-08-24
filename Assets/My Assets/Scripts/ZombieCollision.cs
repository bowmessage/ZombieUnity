using UnityEngine;
using System.Collections;

public class ZombieCollision : MonoBehaviour {
	
	public int health = 100;
	
	// Use this for initialization
	void Start () {
		health = 100;
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
			print ("Zombie hit by bullet");
		}
		else if(objectCollision.gameObject.tag == "SMGBullet")
		{
			health -= Bullet.smgBulletDamage;
			Destroy(objectCollision.gameObject);
			print ("Zombie hit by bullet");
		}
	}
}
