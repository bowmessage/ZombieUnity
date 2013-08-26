using UnityEngine;
using System.Collections;

public class HouseCollision : MonoBehaviour {
	
	ParticleEmitter woodParticles;
	
	// Use this for initialization
	void Start () {
		woodParticles = transform.Find("BloodSplat").Find("Main").particleEmitter;
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
		woodParticles.transform.position = objectCollision.transform.position;
		woodParticles.Emit();
	}
}
