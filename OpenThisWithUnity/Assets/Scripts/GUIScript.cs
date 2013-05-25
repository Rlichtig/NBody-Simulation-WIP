using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {
	/* storage from main menu:
	/ sun: mass, temp?.
	/ planet: mass, velocity, distance
	*/
	float mass;
	float temperature;
	float averageVelocity;
	float distanceFromStar;

	ArrayList starData;
	ArrayList planetData;
	ArrayList systemData;
	
	public Texture btnTexture;
	
	string solarMassString0 = "Enter Mass of Star (JM)";
	string planetMassString0 = "Enter Mass of Planet (JM)";
	string planetSpeedString0 = "Enter Average Speed of planet (km/s)";
	string planetDistanceFromStar0 = "Enter distance from Star (AU)";
	string solarMassString;
	string planetMassString;
	string planetSpeedString;
	string planetDistanceFromStar;

	
	// Fixed Update
	void FixedUpdate(){

	}
	
	// OnGUI
	void OnGUI() {
		GUI.matrix = Matrix4x4.TRS( Vector3.zero, Quaternion.identity, new Vector3( Screen.width / 1024.0f, Screen.height / 768.0f, 1.0f ) );
		// Making first text fields
		solarMassString0 = GUI.TextField(new Rect(124f, 388f, 150f, 24f), solarMassString0);
		planetMassString0 = GUI.TextField(new Rect(410f, 380f, 160f, 20f), planetMassString0);
		planetSpeedString0 = GUI.TextField(new Rect(427f, 404f, 226f, 20f), planetSpeedString0);
		planetDistanceFromStar0 = GUI.TextField(new Rect(409f, 366f, 180f, 20f), planetDistanceFromStar0);
        
		// Making save + play buttons
		if(GUI.Button(new Rect(750, 400, 60, 60), "Start")){
			Application.LoadLevel("Simulation");	
		}
		
		if (!btnTexture) {
            Debug.LogError("Please assign a texture on the inspector");
            return;
        }
		
        if (GUI.Button(new Rect(10, 70, 50, 30), "+"))
            Debug.Log("Clicked the button with text");
        
      	//stringToEdit = GUI.TextField (new Rect (10, 10, 200, 20), stringToEdit, 25);   
    }
} 
 

