using UnityEngine;
using System.Collections;

//script for the ragdoll
public class ZombieDeath : MonoBehaviour {
	
	public float disappearTimer;
	public int deathForce = 50;
	public GameObject ragdollZombieNoCollider;
	
	// Use this for initialization
	void Start () {
		Vector3 direction = transform.position - GameObject.FindWithTag("Player").transform.position;
		direction.Normalize();
		this.rigidbody.AddForce(direction * deathForce, ForceMode.Impulse);
		disappearTimer = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (disappearTimer < 0)
			removeZombie();
		else
			disappearTimer -= Time.deltaTime;
		print ("ragdollzombienocollider is " + ragdollZombieNoCollider.ToString());
	}
	
	void removeZombie()
	{
		print("RemoveZombie called");
		//makes the zombie fall through the floor then dissappear
		GameObject ragdollZombie = (GameObject)Instantiate(ragdollZombieNoCollider, this.transform.position, this.transform.rotation);
		Component[] oldTransforms = this.GetComponentsInChildren(typeof(Transform));
		Component[] newTransforms = ragdollZombie.GetComponentsInChildren(typeof(Transform));
		for(int i = 0; i < oldTransforms.Length; i++)
		{
			newTransforms[i].transform.position = oldTransforms[i].transform.position;
			newTransforms[i].transform.rotation = oldTransforms[i].transform.rotation;
		}
		Destroy(this.gameObject);
	}
}
