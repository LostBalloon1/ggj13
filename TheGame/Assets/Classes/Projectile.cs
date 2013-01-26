using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public static Projectile Instance;   

 
    void Awake() 
    {      
        Instance = this;	
	}
     
 

    void Update () {
        transform.position += Time.deltaTime * 4.0f * transform.forward;	
	}
}
    
	
	

	
    

