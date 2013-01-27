using UnityEngine;
using System.Collections;

public class HeatFan : Fan {

	// Use this for initialization
	void Start () {
		base.Start();
	}
	
	// Update is called once per frame
	void Update () {
		base.Update();
	}
	
	protected override void fanObjects (Collider other)	{
	}

}
