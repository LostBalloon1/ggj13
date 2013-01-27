using UnityEngine;
using System.Collections;

public class Ressource : MonoBehaviour {

    private int ressource = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void takeRessource(int amount)
    {
		Debug.Log("Ressource:" + ressource);
		ressource += amount;
    }
}
