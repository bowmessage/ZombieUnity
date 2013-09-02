using UnityEngine;
using System.Collections;

//script for the ragdoll
public class ZombieDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.rigidbody.AddForce(new Vector3(75,0,0), ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
