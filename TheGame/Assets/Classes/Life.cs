using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

    public int hp = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void takeDamage(int amount)
    {
        hp -= amount;

        if (hp <= 0)
        {
            //kill me -> look into the function Destroy
        }
    }
}
