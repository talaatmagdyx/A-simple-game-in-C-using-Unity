using UnityEngine;
using System.Collections;

public class TimerLevel1 : MonoBehaviour 
{
	public float timer = 20.0f; //A decimal place number
	public GameObject player; //The player gameobject

	public GUIStyle customGUIStyle; //A GUIStyle which holds the styling for any GUI element
	
	public bool begin = false; //The boolean to control whether begin should be true or false
	
	void Update()
	{
		if(begin == true) //if begin is set to true
		{
			timer -= Time.deltaTime; //timer minus the actual ingame time
		}

		if(timer <= 0) //if timer ever reaches zero
		{
			player.GetComponent<HealthControllerLevel1>().lifeCounter--; //Get the player component "HealthControllerLevel1" and variable lifecounter is taken away by 1.
			timer = 20; //we set timer to 20 again
			player.GetComponent<HealthControllerLevel1>().Respawn();
		}
	}

	void OnGUI()
	{
		GUI.Box (new Rect(25, 120, 25, 20), "" + timer.ToString("0"), customGUIStyle); //Creating a GUI Box at the position stated, then setting the float of "Timer" to a single number and passing it the guistyle
	}
}
