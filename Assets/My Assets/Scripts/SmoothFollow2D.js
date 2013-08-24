#pragma strict

var target : Transform;
var smoothTime = 0.25;
private var thisTransform : Transform;
private var velocity : Vector3;

function Start()
{
	thisTransform = transform;
	target = GameObject.FindWithTag ("Player").transform;
}

function Update() 
{
	if(target != null)
	{
		thisTransform.position.x = Mathf.SmoothDamp( thisTransform.position.x, 
			target.position.x, velocity.x, smoothTime);
		thisTransform.position.z = Mathf.SmoothDamp( thisTransform.position.z, 
			target.position.z, velocity.z, smoothTime);
	}
}