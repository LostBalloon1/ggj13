using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Fan : MonoBehaviour {
	
	
	
	// Use this for initialization
	void Start () {
		ready = true;
		activated = false;
		position.x = gameObject.transform.up.x;
		position.y = gameObject.transform.up.y;
		position.z = 0;	
	}
	
	
	// Update is called once per frame
	void Update () {
		now = Time.realtimeSinceStartup;
		
		//if fan life is depleted
		if(activated && lifeForce <= 0)
		{
			ready = false;
			deactivateFan();
			Debug.Log("Fan Disabled" + lifeForce);
		}
		
		// if fan is empty and regenerating
		if(!activated && now > lastRegen + restInterval)
		{
			lifeForce++;
			if(lifeForce >= 10){
				ready = true;
				activated = false;
				Debug.Log("Fan Enabled");
			}
			lastRegen = Time.realtimeSinceStartup;
		}
		if(activated && now > lastAttack + updateInterval)
		{
	      	lifeForce--;
		}
	}
	
	// Add colliding object to the list, and start fan
	void OnTriggerEnter(Collider other) {
		if(other.rigidbody && ready){
		
			if(!activated){
				activated = true;
			}
			attackEnemies(other.gameObject);
			lastAttack = Time.realtimeSinceStartup;
		}
	}
	
	//apply force do colliding object
	void OnTriggerStay(Collider other) {
		if(other.rigidbody && ready){
			if(!activated){
				activated = true;
			}
			
			fanObjects(other);
			
			//if fan activated, lose life force and attack enemies.
			if(activated && now > lastAttack + updateInterval)
			{
				lastAttack = Time.realtimeSinceStartup;
				attackEnemies(other.gameObject);
			}
		}
    }
	
	//deactivates the fan
	void deactivateFan(){
		activated = false;			
		lastRegen = Time.realtimeSinceStartup;
	}
		
	
	void attackEnemies(GameObject enemy){
		Life damage = enemy.GetComponent<Life>();
		if(damage != null)
		{
			damage.takeDamage(powerAttack);
		}

	}
	
	//force objects
	void fanObjects(Collider other){
   		other.rigidbody.AddForce(position * force);
	}
	
	//variables
	private float lastAttack;
	private float lastRegen;
	private List<GameObject> enemies;
	private float now;
	Vector3 position;
	int lifeForce = 10;
	bool activated;
	bool ready;
	
	//constants 
	private const int force = 20;
	private const int powerAttack = 2;
	private const float updateInterval = 0.5F;
	private const float restInterval = 1.0F;
}