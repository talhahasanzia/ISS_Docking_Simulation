using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	int i=1;
	public GameObject C1,C2,C3;
	// Use this for initialization
	void Start () {
		C2.SetActive (false);
		C3.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	


		if (Input.GetKeyDown (KeyCode.C)) {
			if(i>3)
				i=1;
			else
			i++;
		

			if(i==1)
			{
				C1.SetActive(true);
				C2.SetActive (false);
				C3.SetActive (false);

			}
			if(i==2)
			{
				C1.SetActive(false);
				C2.SetActive (true);
				C3.SetActive (false);
				
			}
			if(i==3)
			{
				C1.SetActive(false);
				C2.SetActive (false);
				C3.SetActive (true);
				
			}
		
		}


	}
}
