using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public float speed = 6.0f;
	private float playerHeightDif;	//used to get point from camera to player
	
	void Start () {
		playerHeightDif = Camera.main.transform.position.y - this.gameObject.transform.position.y;
	}
	
	void Update()
	{
		move();
		rotate();
	}
	
	public void move()
	{
		Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		//only normalize if magnitude > 1, as the player can go slower as well
		if(direction.magnitude > 1)
			direction = direction.normalized;
		this.gameObject.transform.Translate(direction * speed * Time.deltaTime, Space.World);
	}
	
	public void rotate()
	{
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;
		
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(new Vector3(mouseX, mouseY, playerHeightDif));
		worldPos.y = this.gameObject.transform.position.y;
		transform.LookAt(worldPos);
		transform.Rotate(new Vector3(0,6,0));
	}
}