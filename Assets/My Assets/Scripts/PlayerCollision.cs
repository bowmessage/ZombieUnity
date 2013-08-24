using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
	
	public int health = 100;
	public static int damageFromZombie = 1;
	
	// Use this for initialization
	void Start () {
		health = 100;
	}
	
	void Update()
	{
		if (health <= 0)
			Destroy(this.gameObject);
	}
	
	void OnCollisionStay(Collision objectCollision)
	{		
		if(objectCollision.gameObject.tag == "Zombie")
		{
			health -= PlayerCollision.damageFromZombie;
			print ("Player hit by zombie, health: " + health);
		}
	}
	
	public int getHealth()
	{
		return health;
	}
}
