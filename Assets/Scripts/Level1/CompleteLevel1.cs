using UnityEngine;
using System.Collections;

public class CompleteLevel1 : MonoBehaviour 
{
	void OnTriggerEnter(Collider Col) //Collision detection
	{
		if(Col.tag == "Player") //If we enter a collider and the Third Person Controller is tagged "Player"
		{
			Application.LoadLevel("ToLevel2"); //Load the level "ToLevel2"
		}
	}
}
