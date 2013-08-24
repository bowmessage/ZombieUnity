using UnityEngine;
using System.Collections;

public class ZombieMovement : MonoBehaviour {
	
	public float speed;
	public float rotationSpeed = 5.0f;
	public Transform target;
	private Transform thisTransform;
	
	void Start () {
		thisTransform = this.gameObject.transform;
		target = GameObject.FindWithTag("Player").transform;
		speed = 4.5f;
	}
	
	void Update()
	{
		if(target != null)
		{
			rotate();
			move();
		}
	}
	
	public void move()
	{		
		thisTransform.Translate(thisTransform.forward * speed * Time.deltaTime, Space.World);
	}
	
	public void rotate()
	{
		thisTransform.rotation = Quaternion.Slerp(thisTransform.rotation,
    		Quaternion.LookRotation(target.position - thisTransform.position), rotationSpeed*Time.deltaTime);
	}
}