using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

    public int hp = 10;
	private Ressource ressource;
	public int numRessource = 1;

	// Use this for initialization
	void Start () {
		ressource = (Ressource)FindObjectOfType(typeof(Ressource)) as Ressource;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void takeDamage(int amount)
    {
		hp -= amount;
        if (hp <= 0)
        {
			if(ressource != null)
			{
				ressource.takeRessource(numRessource);
			}
			Destroy(this.gameObject);//kill me -> look into the function Destroy
        }
    }
}
