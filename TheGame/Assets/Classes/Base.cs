using UnityEngine;
using System.Collections;

public class Base : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        EnemyAI other = collider.gameObject.GetComponent<EnemyAI>();
        if (other != null)
        {
            Destroy(other.gameObject);
            gameObject.GetComponent<Life>().takeDamage(1);
        }
    }
}
