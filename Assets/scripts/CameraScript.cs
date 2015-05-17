using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {	
		if(Input.GetKey("a")){
			//	float inputX = Input.GetAxis("Mouse ScrollWheel");
			GetComponent<Camera> ().transform.Rotate(Vector3.up * -2F);

			//rot.y+=(float)0.05;
			//GetComponent<Camera> ().transform.rotation= rot;
		}
		if(Input.GetKey("d")){
			//	float inputX = Input.GetAxis("Mouse ScrollWheel");
			GetComponent<Camera> ().transform.Rotate(Vector3.up * 2F);
		}
		if(Input.GetKey("w")){

			GetComponent<Camera> ().transform.position += GetComponent<Camera> ().transform.forward * 0.05F *1;

		}if(Input.GetKey("s")){
			GetComponent<Camera> ().transform.position += GetComponent<Camera> ().transform.forward * 0.05F *-1;
		}
		
		if(Input.GetKey("o")){
			//	float inputX = Input.GetAxis("Mouse ScrollWheel");
			GetComponent<Camera> ().orthographicSize = GetComponent<Camera> ().orthographicSize + 0.1F;
		}if(Input.GetKey("k")){
			//	float inputX = Input.GetAxis("Mouse ScrollWheel");
			GetComponent<Camera> ().orthographicSize = GetComponent<Camera> ().orthographicSize - 0.1F;
		}
		
		
		
		float inputX = Input.GetAxis("Mouse ScrollWheel");
		if (inputX != 0) {
			if (GetComponent<Camera> ().orthographicSize+( 10 * inputX)>0)		{	
				GetComponent<Camera> ().orthographicSize = GetComponent<Camera> ().orthographicSize + 2 * inputX;
			}
			if (GetComponent<Camera> ().orthographicSize<=0){
				GetComponent<Camera> ().orthographicSize=0;
			}
		}
		
	}
}