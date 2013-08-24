using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public static int pistolBulletDamage = 40;
	public static int smgBulletDamage = 10;
	
	// Use this for initialization
	void Start () {
		//to make sure any stray bullets in the that werent 
		//detected by house or zombie are deleted after 5 seconds
		Destroy(this.gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
//	public void onCollisionEnter(Collision collision)
//	{
//		print ("destroying bullet");
//		Destroy(this.gameObject);
//	}
}
