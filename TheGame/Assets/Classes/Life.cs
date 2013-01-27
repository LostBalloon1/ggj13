using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

    public int hp = 50;

	// Use this for initialization
	void Start () {
		Debug.Log("HP:" + hp);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void takeDamage(int amount)
    {
		Debug.Log("HP:" + hp);
		hp -= amount;
        if (hp <= 0)
        {
			Destroy(this.gameObject);//kill me -> look into the function Destroy
        }
    }
}
