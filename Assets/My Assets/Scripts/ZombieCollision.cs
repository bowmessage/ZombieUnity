using UnityEngine;
using System.Collections;

public class ZombieCollision : MonoBehaviour {
	
	public int health = 100;
	public GameObject ragdollZombieObject;
	ParticleEmitter bloodMain;
	
	// Use this for initialization
	void Start ()
	{
		bloodMain = transform.Find("BloodSplat").Find("Main").particleEmitter;
	}
	
	void Update()
	{
		if (health <= 0)
			killZombie();
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
		
	void killZombie()
	{
		GameObject ragdollZombie = (GameObject)Instantiate(ragdollZombieObject, this.transform.position, this.transform.rotation);
		Component[] oldTransforms = this.GetComponentsInChildren(typeof(Transform));
		Component[] newTransforms = ragdollZombie.GetComponentsInChildren(typeof(Transform));
		for(int i = 0; i < oldTransforms.Length; i++)
		{
			newTransforms[i].transform.position = oldTransforms[i].transform.position;
			newTransforms[i].transform.rotation = oldTransforms[i].transform.rotation;
		}
		Destroy(this.gameObject);
	}
}
