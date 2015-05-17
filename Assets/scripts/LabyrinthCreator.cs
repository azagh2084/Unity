using UnityEngine;
using System.Collections;

public class LabyrinthCreator : MonoBehaviour {

	public GameObject floor;
	public GameObject wall;

	int[,] lab = { 
		{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, 
		{ 1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
		{ 1, 0, 1, 1, 0, 1, 1, 0, 0, 1},
		{ 1, 0, 1, 0, 0, 1, 1, 0, 0, 1},
		{ 1, 0, 1, 1, 0, 0, 0, 0, 0, 1},
		{ 1, 0, 0, 0, 0, 0, 1, 0, 0, 1},
		{ 1, 0, 0, 0, 1, 1, 1, 0, 0, 1},
		{ 1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
		{ 1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
		{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
		};

	void Start () {

		for(int i=0;i<10;i++){
			for(int j=0;j<10;j++){


				if (lab[i,j]==0){				
					GameObject obj= (GameObject)Instantiate(floor,new Vector3(i-5,0,j-5),Quaternion.identity);		
				}else{
					Instantiate(wall,new Vector3(i-5,1,j-5),Quaternion.identity);
				}
			}
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
