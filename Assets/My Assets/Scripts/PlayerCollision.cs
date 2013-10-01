using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {
	
	public static int health = 100;
	public static int damageFromZombie = 1;
	private Vector3 startingPosition;
	
	// Use this for initialization
	void Start () {
		health = 100;
		startingPosition = transform.position;
	}
	
	void Update()
	{
		if (health <= 0)
			playerDead();
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
	
	private void playerDead()
	{
		//Destroy(this.gameObject);
		transform.position = startingPosition;
		health = 100;
	}
}
