using UnityEngine;
using System.Collections;

public class ZombieNoCollider : MonoBehaviour {
	
	public float disappearTimer;
	
	// Use this for initialization
	void Start () {
		disappearTimer = 1;
	}
	
	// Update is called once per frame
	void Update () {
		disappearTimer -= Time.deltaTime;
		
		if(disappearTimer < 0)
			Destroy(this.gameObject);
	}
}
