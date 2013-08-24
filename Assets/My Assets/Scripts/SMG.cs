using UnityEngine;
using System.Collections;

public class SMG : MonoBehaviour {
	
	public Rigidbody projectile;
	public int bulletSpeed;
	public GameObject flare;
	private int frameCounter;
	public int bulletDelay;  
	
	// Use this for initialization
	void Start () {
		frameCounter = 0;
		bulletSpeed = 30;
		bulletDelay = 3;
	}
	
//	// Update is called once per frame
	void Update () {
		
		frameCounter++;
		if(Input.GetMouseButton(0))
		{
			if(frameCounter % bulletDelay == 0)
				shootBullet();
		}
		
		//makes it to where each bullet flare only happens for 5 frames
		if(frameCounter > 5)
			enableFlare(false);
	}
	
	public void shootBullet()
	{
		enableFlare(true);
		frameCounter = 0;
		Vector3 correction = new Vector3(0, -.3f, 0);	//to make bullet start at end of barrel
		Vector3 spawnLocation = transform.position + transform.TransformDirection(correction);
		Rigidbody bullet = (Rigidbody)Instantiate(projectile, spawnLocation, transform.rotation);
		bullet.velocity = transform.TransformDirection(new Vector3(0, -bulletSpeed, 0));
	}
	
	public void enableFlare(bool on){
		transform.parent.Find("Flare").particleSystem.enableEmission = on;
	}
}
