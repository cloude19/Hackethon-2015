using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Rotatecon : MonoBehaviour {
	public int speed;
	public  Vector3 vectors; 
	public  Vector3 vectorss; 


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.RightArrow)){ //rotate model on Y axis
			transform.Rotate(vectors, speed * Time.deltaTime);

		}

		if(Input.GetKey(KeyCode.LeftArrow)){ //rotate model on Y axis				
			transform.Rotate(vectorss, speed * Time.deltaTime);

		}

		if(Input.GetKey(KeyCode.Space)){//rotate model on Y axis
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}


	
	}
}
