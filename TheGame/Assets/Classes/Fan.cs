using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Fan : MonoBehaviour {
	
	
	
	// Use this for initialization
	protected void Start () {
		ready = true;
		activated = false;
		position.x = gameObject.transform.up.x;
		position.y = gameObject.transform.up.y;
		position.z = 0;	
		lifeBar = GameObject.Find("LifeBar");
	}
	
	
	// Update is called once per frame
	protected void Update () {
		now = Time.realtimeSinceStartup;
		
		//if fan life is depleted
		if(activated && lifeForce <= 0)
		{
			ready = false;
			deactivateFan();
			
			//Debug.Log("Fan Disabled" + lifeForce);
		}
		
		// if fan is empty and regenerating
		if(!activated && now > lastRegen + restInterval)
		{
			lifeForce++;
			if(lifeForce >= 10){
				ready = true;
				activated = false;
				//Debug.Log("Fan Enabled");
			}
			lastRegen = Time.realtimeSinceStartup;
            changeLifeBar();
		}
		if(activated && now > lastAttack + updateInterval)
		{
	      	lifeForce--;
            changeLifeBar();
		}
	}
	
	// Add colliding object to the list, and start fan
	protected void OnTriggerEnter(Collider other) {
		if(other.rigidbody && ready){
		
			if(!activated){
				activated = true;
				activatedAnim();
			}
			attackEnemies(other.gameObject);
			lastAttack = Time.realtimeSinceStartup;
		}
	}
	
	//apply force do colliding object
	protected void OnTriggerStay(Collider other) {
		if(other.rigidbody && ready){
			if(!activated){
				activated = true;
				activatedAnim();
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
	protected void deactivateFan(){
		activated = false;			
		lastRegen = Time.realtimeSinceStartup;
		stopAnim();
	}
		
	
	protected void attackEnemies(GameObject enemy){
		Life damage = enemy.GetComponent<Life>();
		if(damage != null)
		{
			damage.takeDamage(powerAttack);
		}

	}
	
	protected virtual void activatedAnim(){
		animation.wrapMode = WrapMode.Loop;
		animation.Play("Wind");
	}
	
	protected virtual void stopAnim(){
		animation.Stop("Wind");
	}
	
	//force objects
	protected virtual void fanObjects(Collider other){
   		other.rigidbody.AddForce(position * force);
	}

    protected void changeLifeBar()
    {
        Texture texture;
		switch (lifeForce)
        {
            case 0: texture = Resources.Load("HUD_Bar_0", typeof(Texture)) as Texture; break;
			case 1: texture = Resources.Load("HUD_Bar_3", typeof(Texture)) as Texture; break;
			case 2: texture = Resources.Load("HUD_Bar_6", typeof(Texture)) as Texture; break;
			case 3: texture = Resources.Load("HUD_Bar_9", typeof(Texture)) as Texture; break;
			case 4: texture = Resources.Load("HUD_Bar_12", typeof(Texture)) as Texture; break;
			case 5: texture = Resources.Load("HUD_Bar_15", typeof(Texture)) as Texture; break;
			case 6: texture = Resources.Load("HUD_Bar_18", typeof(Texture)) as Texture; break;
			case 7: texture = Resources.Load("HUD_Bar_21", typeof(Texture)) as Texture; break;
			case 8: texture = Resources.Load("HUD_Bar_24", typeof(Texture)) as Texture; break;
			case 9: texture = Resources.Load("HUD_Bar_27", typeof(Texture)) as Texture; break;
			case 10: texture = Resources.Load("HUD_Bar_29", typeof(Texture)) as Texture; break;
			default: texture = Resources.Load("HUD_Bar_29", typeof(Texture)) as Texture; break;
        }
		lifeBar.renderer.material.mainTexture = texture;
    }

	//variables
	protected GameObject lifeBar;
	protected GameObject target;
	protected float lastAttack;
	protected float lastRegen;
	protected float now;
	protected Vector3 position;
	protected int lifeForce = 10;
	protected bool activated;
	protected bool ready;
	
	//constants 
	protected const int force = 20;
	protected const int powerAttack = 2;
	protected const float updateInterval = 0.5F;
	protected const float restInterval = 1.0F;
}