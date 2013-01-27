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
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
