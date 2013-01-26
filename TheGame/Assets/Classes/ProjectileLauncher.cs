using UnityEngine;
using System.Collections;

public class ProjectileLauncher : MonoBehaviour {

    public Transform prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        GetShootInput();    
       
	}

    void GetShootInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            GameObject.Instantiate(prefab, transform.position, transform.rotation);

        }
        return;
    }
	
}
