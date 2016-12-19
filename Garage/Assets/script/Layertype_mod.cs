using UnityEngine;
using System.Collections;

public class Layertype_mod : MonoBehaviour {
	int change = 0;
	string stringToEdit = "From: To: ";
	int green = 0;
	string collidename = "";
	// Use this for initialization
	void Start () {
		//can i edtion this without functin other jp

	}
		


	public void onClick(string name){
		//Application.LoadLevel("SomeLevel"); // this is how you would load another level
		print("this button works");
		MeshRenderer gameobjectreder = gameObject.GetComponent<MeshRenderer> ();



		if (name == "Student"){
			//print ("victory");

			change = 1;
			}

		if (name == "Faculty"){
			//print ("victory");

			change = 2;
		}

		if (name == "Reserved"){
			//print ("victory");

			change = 3;
		
		}

		if (name == "Metered"){
			//print ("victory");

			change = 4;
		}
	}


	void OnMouseDown()
	{
		
	print (this.gameObject.name);

		 collidename = this.gameObject.name;
	}


	 Color choice1 = Color.white;
	 Color choice2 = Color.blue;
    public Color lerpedColor = Color.white;



	// Update is called once per frame
	void Update () {




		MeshRenderer gameobjectreder = GameObject.Find (collidename).GetComponent<MeshRenderer> ();  //GetComponent<MeshRenderer> ();


		gameobjectreder.material.color =  lerpedColor = Color.Lerp(choice1, choice2, Mathf.PingPong(Time.time, 1));

		if (change == 1) {
		
		
			choice1 = Color.white;
			choice2 = Color.blue;
		}

		if (change == 2) {


			choice1 = Color.white;
			choice2 = Color.red;
		}

		if (change == 3) {


			choice1 = Color.white;
			choice2 = Color.green;
			print ("i was here");
			green = 1;
		}

		if (change == 4) {


			choice1 = Color.white;
			choice2 = Color.yellow;
		}



	
	
	}

	void OnGUI() {
		if (green >= 1) {
			stringToEdit = GUI.TextField (new Rect (10, 10, 200, 20), stringToEdit, 25);
			TextMesh textObject = GameObject.Find("New Text").GetComponent<TextMesh>(); 
			textObject.text = stringToEdit;
			//textobject.text = stringToEdit;
			//TextMesh yo = new TextMesh(); 
			//yo.text = stringToEdit;

		}
	}








}

