using UnityEngine;
using System.Collections;

public class ShuttleMovement : MonoBehaviour {
    public static bool IsAligned=false;
    public Transform StationPosition;


	public uint RotateSpeed=1;
	Rigidbody rg_Object;
	// Use this for initialization
	void Start () {
		rg_Object = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {


        if (IsAligned)
        {
           
           // transform.position = new Vector3(StationPosition.position.x,transform.position.y,StationPosition.position.z);
        
        
        }





        float inputX = Input.acceleration.x;
        float inputY = Input.acceleration.y;


		if (Input.GetKey (KeyCode.Mouse1)) {
		

			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (Vector3.zero), 2*Time.deltaTime);
			rg_Object.angularVelocity=Vector3.zero;
		
		
		
		}

		if (Input.GetKey (KeyCode.Q)) {
		
			this.gameObject.transform.Rotate(0,-RotateSpeed*10*Time.deltaTime,0);
		
		
		}
		if (Input.GetKey (KeyCode.E)) {
			
			this.gameObject.transform.Rotate(0,RotateSpeed*10*Time.deltaTime,0);
			
			
		}
       
        
            if (Input.GetKey(KeyCode.A) || inputX<0.0f)
            {

                if (rg_Object.velocity.x > -6)
                    rg_Object.AddForce(-transform.right * 10);


            }


            if (Input.GetKey(KeyCode.D) || inputX>0.0f)
            {

                if (rg_Object.velocity.x < 6)
                    rg_Object.AddForce(transform.right * 10);


            }
            if (Input.GetKey(KeyCode.W) || inputY>0.0f)
            {


                if (rg_Object.velocity.z < 6)
                    rg_Object.AddForce(transform.forward * 10);
            }
            if (Input.GetKey(KeyCode.S) || inputY<0.0f)
            {
                if (rg_Object.velocity.z > -6)
                    rg_Object.AddForce(-transform.forward * 10);


            }
        
		if (Input.GetKey (KeyCode.F)) {
			if ( rg_Object.velocity.y>-2)
				rg_Object.AddForce (-transform.up * 5);
			
			
		}
		if (Input.GetKey (KeyCode.Space)) {
			if ( rg_Object.velocity.y<3)
				rg_Object.AddForce (transform.up * 5);
			
			
		}


		}

}
