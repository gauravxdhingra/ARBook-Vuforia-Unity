using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AeroplaneMoveScript : MonoBehaviour {
    public float xValue, yValue, zValue;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(xValue, yValue, zValue) * Time.deltaTime);
    }
}
