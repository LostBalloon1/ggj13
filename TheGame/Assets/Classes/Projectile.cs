using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public static Projectile Instance; 
    public

    void Awake()
    {
        Instance = this;

    }

    void Start()
    {
        StartCoroutine(ProjectileThrow());
    }

    

    void Update()
    {
        transform.position += Time.deltaTime * 2.0f * transform.right;
        transform.Rotate(0, 0, 25);
    }

    IEnumerator ProjectileThrow()
    {

        
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
	
	// Add colliding object to the list, and start fan
	protected void OnTriggerEnter(Collider other) {
		Life damage = other.gameObject.GetComponent<Life>();
		if(damage != null)
		{
			damage.takeDamage(powerAttack);
			Destroy(this.gameObject);
		}
	}
	private const int powerAttack = 5;
}
    
	
	

	
    

