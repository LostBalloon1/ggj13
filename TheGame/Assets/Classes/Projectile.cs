using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public static Projectile Instance;   
    private Vector3 shootDirection;
 
    void Awake() 
    {      
        Instance = this;
        shootDirection = Input.mousePosition;

        Debug.Log("Position" + shootDirection + "/n");	
    }
 

    void Update () {
        
        transform.position += Time.deltaTime * 4.0f * transform.right;	
	}
}
    
	
	

	
    

