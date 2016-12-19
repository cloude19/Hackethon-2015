using UnityEngine;
using System.Collections;

public class mouseclick : MonoBehaviour {
	int change = 0;
	public void onClick(string name){
		//Application.LoadLevel("SomeLevel"); // this is how you would load another level
		print("this button works");
		MeshRenderer gameobjectreder = gameObject.GetComponent<MeshRenderer> ();

	

		if (name == "Student"){
			print ("victory");

			change = 0;


			}
}





		

}