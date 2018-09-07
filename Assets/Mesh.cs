using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesh : MonoBehaviour {


    //trying to create a mesh thru code
    // to build need to assign verts

    public MeshFilter filter;

    public Vector3[] verts;
    public int[] tris;



	void Start () {
        Mesh myNewMesh = new Mesh();
        myNewMesh.vertices = verts;
        myNewMesh.triangles = tris;

        filter.mesh = myNewMesh;
    }
	
	
	void Update () {
		
	}
}
