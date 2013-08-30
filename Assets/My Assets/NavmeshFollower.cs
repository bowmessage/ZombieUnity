using UnityEngine;
using System.Collections;

public class NavmeshFollower : MonoBehaviour {
	
	private GameObject navmeshObj;
	private Mesh navmesh;
	
	
	// Use this for initialization
	void Start () {
		navmeshObj = GameObject.FindGameObjectWithTag("Navmesh");
		if(navmeshObj == null){
			print ("Error: No navmesh found.");
		}
		MeshFilter navmeshObjMeshFilter = (MeshFilter)navmeshObj.GetComponent<MeshFilter>();
		if(navmeshObjMeshFilter == null){
			print ("Error: Navmesh object has no mesh filter.");
		}
		
		
		//This is the actual mesh which stores vertex and face information.
		navmesh = navmeshObjMeshFilter.mesh;
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
