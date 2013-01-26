using UnityEngine;
using System.Collections;

public class PaperBoy : MonoBehaviour {	

     public static CharacterController CharacterController;
     public static PaperBoy Instance;
    

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

        MovEngine.Instance.UpdateMov();
    }    
    

    void  GetMouvementInput()
    {

        var deadZone = 0.1f;        

        MovEngine.Instance.MoveVector = Vector3.zero;

        

        if (Input.GetAxis("Vertical") > deadZone || Input.GetAxis("Vertical") < -deadZone)

            MovEngine.Instance.MoveVector += new Vector3(0, Input.GetAxis("Vertical"), 0);

        

        if (Input.GetAxis("Horizontal") > deadZone || Input.GetAxis("Horizontal") < -deadZone)

            MovEngine.Instance.MoveVector += new Vector3( Input.GetAxis("Horizontal"), 0,0);

    }   

}
	
	

