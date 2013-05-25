using UnityEngine;
using System.Collections;

public class AsteroidPhysics : MonoBehaviour {
	
	public float v;
	
	// Use this for initialization
	void Start () {
		v = .8f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.Translate( new Vector3( v *Time.deltaTime, 0, 0 ), Space.World );
		gameObject.transform.Rotate(0,-5f,0);
	}
}
