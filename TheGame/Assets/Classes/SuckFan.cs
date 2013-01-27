using UnityEngine;
using System.Collections;

public class SuckFan : Fan {

	// Use this for initialization
	void Start () {
		ready = true;
		activated = false;
		position.x = -gameObject.transform.up.x;
		position.y = -gameObject.transform.up.y;
		position.z = 0;	
	}
	
	// Update is called once per frame
	void Update () {
		base.Update();
	}
}
