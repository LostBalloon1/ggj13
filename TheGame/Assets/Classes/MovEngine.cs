using UnityEngine;
using System.Collections;

public class MovEngine : MonoBehaviour {

    public static MovEngine Instance;
    public float MoveSpeed = 10f;
    public Vector3 MoveVector { get; set; }





    void Awake()
    {
        Instance = this;
    }
    

    public void UpdateMov()
    {
       SnapAlignCharacterwithCamera();
        ProcessMov();
    }



    void ProcessMov()
    {        
        MoveVector = transform.TransformDirection(MoveVector);        

        if (MoveVector.magnitude > 1)
            MoveVector = Vector3.Normalize(MoveVector);

        MoveVector *= MoveSpeed;
         
        MoveVector *= Time.deltaTime;

        PaperBoy.CharacterController.Move(MoveVector);
       
    }


    void SnapAlignCharacterwithCamera()
    {
        if (MoveVector.x != 0 || MoveVector.z != 0)
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x,
            Camera.mainCamera.transform.eulerAngles.y,
            transform.eulerAngles.z);
        }

    }
}
