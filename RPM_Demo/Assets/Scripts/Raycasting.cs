using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Raycasting : MonoBehaviour {
    public GameObject RaycastOrigin1;
    public GameObject RaycastOrigin2;
    public GameObject RaycastOrigin3;
    public GameObject Shuttle;
    Text textObj;
    Transform OriginRaycast1;
    Transform OriginRaycast2;
    Transform OriginRaycast3;
    string status;
    bool Sensor1 = false, Sensor2 = false, Sensor3 = false;
    bool RotateOrder = false;
	// Use this for initialization
	void Start () {
        OriginRaycast1 = RaycastOrigin1.GetComponent<Transform>();
        OriginRaycast2 = RaycastOrigin2.GetComponent<Transform>();
        OriginRaycast3 = RaycastOrigin3.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {


        Sensor1 = false;
        Sensor2 = false;

       
        RaycastHit RayHit1;
        RaycastHit RayHit2;
        RaycastHit RayHit3;

        if (Physics.Raycast(OriginRaycast1.position, -Vector3.right, out RayHit1, 10))
        {

            Debug.DrawLine(OriginRaycast1.position, RayHit1.point, Color.red);

            if (RayHit1.collider.tag == "PositionSensor")
                Sensor1 = true;


        }
        if (Physics.Raycast(OriginRaycast2.position, -Vector3.right, out RayHit2, 10))
        {

            Debug.DrawLine(OriginRaycast2.position, RayHit2.point, Color.blue);

            if (RayHit2.collider.tag == "PositionSensor")
                Sensor2 = true;

        }

        if (!ShuttleMovement.IsAligned)
        {
            if (Physics.Raycast(OriginRaycast3.position, -Vector3.right, out RayHit3, 10))
            {

                Debug.DrawLine(OriginRaycast3.position, RayHit3.point, Color.magenta);

                if (RayHit3.collider.tag == "CentreSensor")
                {
                    Sensor3 = true;

                    //Rigidbody rg_Object = Shuttle.GetComponent<Rigidbody>();

                    //rg_Object.velocity = Vector3.zero;
                    //rg_Object.angularVelocity = Vector3.zero;
                    status += " centre locked";

                }



            }
        }

        if (Sensor1 == true && Sensor2 == true)
            status = "100% Aligned";
        else
        {



            if (Sensor1 == true)
                status = "50% Aligned";
            else if (Sensor2 == true)
                status = "50% Aligned";
            else
                status = "Alignment Failure";

        }



        if (Sensor3)
            status += "Locked";

//        textObj.text = status;

        Debug.Log(status);


       




        if (Sensor3)
        {

            ShuttleMovement.IsAligned = true;

        }
	}
}
