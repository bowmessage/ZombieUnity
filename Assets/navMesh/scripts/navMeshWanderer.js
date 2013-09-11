#pragma strict

import System.Collections.Generic;

 

var navMeshScript : navMesh;

var path : List.<Vector3> = null;

var targetNodeIndex : int = 0;

var targetNode : Vector3;

 

var moveSpeed : float = 3.0;

var distanceToNode : float = 3.0;

 

function Start () {

    //Find the navmesh script in the scene

    navMeshScript = GameObject.FindObjectOfType(navMesh).GetComponent("navMesh");

}

 

function Update () {

    //If the path is null

    if (path == null) {

        //Find a new random path

        path = navMeshScript.findRandomPath(transform.position);

        targetNodeIndex = 0;

    }

    

    //The end of the path hasn't been reached

    if (targetNodeIndex < path.Count) {

        targetNode = path[targetNodeIndex];

        

        //If the character is close to the target node

        if (Vector3.Distance(transform.position, targetNode) < distanceToNode) {

            //Target the next node

            targetNodeIndex += 1;

        }

    }

    

    //The end of the path has been reached

    else {

        path = null;

    }

    

    //Move towards target node

    transform.position += moveSpeed*(targetNode-transform.position).normalized*Time.deltaTime;

}