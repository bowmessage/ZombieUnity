using UnityEngine;
using System.Collections;

public class HouseCollision : MonoBehaviour {
	
	ParticleEmitter woodParticles;
	
	// Use this for initialization
	void Start () {
		if(transform.Find("BloodSplat") != null)
			woodParticles = transform.Find("BloodSplat").Find("Main").particleEmitter;
		else
			print (this.gameObject.name + " doesn't have the particle emitter.");
	}
	
	void OnCollisionEnter(Collision objectCollision)
	{
		
		if(objectCollision.gameObject.tag == "PistolBullet"
			|| objectCollision.gameObject.tag == "SMGBullet")
		{
			Destroy(objectCollision.gameObject);
			makeParticles(objectCollision);
			print ("House hit by bullet");
		}
	}
	
	void makeParticles(Collision objectCollision)
	{
		if(woodParticles != null)
		{
			woodParticles.transform.position = objectCollision.transform.position;
			woodParticles.Emit();
		}
	}
}
