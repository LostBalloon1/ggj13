using UnityEngine;
using System.Collections;

public class Ressource : MonoBehaviour {

    private int ressource = 50;

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

    public int getRessource()
    {
        
        return ressource;
    }

    public void spendRessource(int ressourceSpent)
    {
       
        ressource = ressource - ressourceSpent;
        Debug.Log("Ressource:" + ressource);
    }

}
