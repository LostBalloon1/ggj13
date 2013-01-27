using UnityEngine;
using System.Collections;

public class Socket : MonoBehaviour {

    public GameObject[] prefabs;
    private GameObject current = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && current == null)
        {
            current = (GameObject)Instantiate(prefabs[0], transform.position, transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && current == null)
        {
            current = (GameObject)Instantiate(prefabs[1], transform.position, Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && current == null)
        {
            current = (GameObject)Instantiate(prefabs[2], transform.position, transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) && current != null)
        {
            Destroy(current);
            current = null;
        }
    }
}
