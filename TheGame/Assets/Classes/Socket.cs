using UnityEngine;
using System.Collections;

public class Socket : MonoBehaviour {

    public GameObject prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            // Destroy what is in the socket
        }
        
    }
}
