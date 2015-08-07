using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StationRotation : MonoBehaviour {

	public GameObject RaycastOrigin1;
	public GameObject RaycastOrigin2;
    public GameObject RaycastOrigin3;
    public GameObject Shuttle;
    
	Transform OriginRaycast1;
	Transform OriginRaycast2;
    Transform OriginRaycast3;
	string status;
    bool Sensor1 = false, Sensor2 = false, Sensor3 = false;
	bool RotateOrder=false;

	Text textObj;

	public GameObject TextStatus;

	// Use this for initialization
	void Start () {
		
		textObj = TextStatus.GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		

	}
}
