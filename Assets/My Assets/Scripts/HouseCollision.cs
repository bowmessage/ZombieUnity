using UnityEngine;
using System.Collections;

public class HouseCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter(Collision objectCollision)
	{
		
		if(objectCollision.gameObject.tag == "PistolBullet"
			|| objectCollision.gameObject.tag == "SMGBullet")
		{
			Destroy(objectCollision.gameObject);
			print ("House hit by bullet");
		}
	}
}
