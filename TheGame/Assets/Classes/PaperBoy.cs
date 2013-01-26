using UnityEngine;
using System.Collections;

public class PaperBoy : MonoBehaviour {	

     public static CharacterController CharacterController;
     public static PaperBoy Instance;
     public Transform prefab;

    void Awake() 
    {

        CharacterController = GetComponent("CharacterController") as CharacterController;
        Instance = this;
    }    

    void Update()

    {
        if (Camera.mainCamera == null)
            return;

        GetMouvementInput();
        GetShootInput();        

        MovEngine.Instance.UpdateMov();
    }

    void GetShootInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Instantiate(prefab, transform.position + 1.0f * transform.forward, transform.rotation);
          

        }
        return;
    }
    

    void  GetMouvementInput()
    {

        var deadZone = 0.1f;        

        MovEngine.Instance.MoveVector = Vector3.zero;

        

        if (Input.GetAxis("Vertical") > deadZone || Input.GetAxis("Vertical") < -deadZone)

            MovEngine.Instance.MoveVector += new Vector3(0, 0, Input.GetAxis("Vertical"));

        

        if (Input.GetAxis("Horizontal") > deadZone || Input.GetAxis("Horizontal") < -deadZone)

        MovEngine.Instance.MoveVector += new Vector3(Input.GetAxis("Horizontal"), 0, 0);

    }   

}
	
	

