using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Script : MonoBehaviour {

    public Vector3 miVector;
    public GameObject myobject;
	// Use this for initialization
	void Start () {
        myobject.transform.position = miVector;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
