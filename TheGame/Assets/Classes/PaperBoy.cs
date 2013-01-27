using UnityEngine;
using System.Collections;

public class PaperBoy : MonoBehaviour {

   
     public static CharacterController CharacterController;
     public static PaperBoy Instance;
     public static GameObject Cam1;
     public static GameObject Cam2;
     public Transform Projectil;
     public int nbProjectil = 5;
     public int projectilShot;
     public int angle = 45;

    void Awake() 
    {

        CharacterController = GetComponent("CharacterController") as CharacterController;
        Instance = this;
        Cam1 = GameObject.Find("Camera");
        Cam2 = GameObject.Find("Camera main");
        Cam2.camera.enabled = !Cam2.camera.enabled;
       
    }    

    void Update()
    {
        if (Cam1.camera.enabled)
        {
            GetMouvementInput();
            GetCameraSwitch();
            GetShootProjectile();
        }
        
         GetCameraSwitch();
        
        MovEngine.Instance.UpdateMov();
       
    }

    void GetMouvementInput()
    {

        var deadZone = 0.1f;

        MovEngine.Instance.MoveVector = Vector3.zero;



        if (Input.GetAxis("Vertical") > deadZone || Input.GetAxis("Vertical") < -deadZone)

            MovEngine.Instance.MoveVector += new Vector3(0, Input.GetAxis("Vertical"), 0);




        if (Input.GetAxis("Horizontal") > deadZone || Input.GetAxis("Horizontal") < -deadZone)

            MovEngine.Instance.MoveVector += new Vector3(Input.GetAxis("Horizontal"), 0, 0);

    }   

    void GetCameraSwitch()
    {
      if( Input.GetKeyDown("space"))
      {
          Cam1.camera.enabled = !Cam1.camera.enabled;
          Cam2.camera.enabled = Cam2.camera.enabled;

      }
     

    }

    void GetShootProjectile()
    {

        if (Input.GetMouseButtonDown(0))
        {

            GameObject.Instantiate(Projectil, transform.position + 2.0f * Input.GetAxis("Horizontal") * transform.right, transform.rotation);
            animation.Play ("Throw");
          
              
        }
    }


   

}
	
	

