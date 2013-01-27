using UnityEngine;
using System.Collections;

public class Socket : MonoBehaviour {

    public GameObject[] prefabs;
    private GameObject current = null;

    public int ressourceAvailableForFan;
    private Ressource ressource;

    void Start()
    {
        ressource = (Ressource)FindObjectOfType(typeof(Ressource)) as Ressource;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {
        ressourceAvailableForFan = ressource.getRessource();

       
            if (Input.GetKeyDown(KeyCode.Alpha1) && current == null && ressourceAvailableForFan > 9 )
            {
                current = (GameObject)Instantiate(prefabs[0], transform.position, transform.rotation);
                ressource.spendRessource(10);
            }
             
            else if (Input.GetKeyDown(KeyCode.Alpha2) && current == null && ressourceAvailableForFan > 29)
            {
                current = (GameObject)Instantiate(prefabs[1], transform.position, transform.rotation);
                ressource.spendRessource(30);
            }
        
            //else if (Input.GetKeyDown(KeyCode.Alpha3) && current == null)
            //{
            //    current = (GameObject)Instantiate(prefabs[2], transform.position, transform.rotation);
            //}
        
        else if (Input.GetKeyDown(KeyCode.Alpha4) && current != null)
        {
            Destroy(current);
            current = null;
        }
    }
}
