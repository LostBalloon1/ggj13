using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public static Projectile Instance;
    private Vector3 mousePosition;
 
    void Awake() 
    {      
        Instance = this;
	}

    void Start()
    {
        //RaycastHit hit;
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(r, 100.0f))
        {
            //float distanceToGround = hit.distance;

            mousePosition = r.GetPoint(1);
            Debug.Log(mousePosition.x + " " + mousePosition.y + " " + mousePosition.z);
        }
    }

    void Update () {
        //transform.position += Time.deltaTime * 4.0f * mousePosition;
        transform.position += new Vector3(Time.deltaTime * 4.0f, 0, 0);
        transform.Rotate(45 * Time.deltaTime, 45 * Time.deltaTime, 45 * Time.deltaTime);
	}
}
    
	
	

	
    

