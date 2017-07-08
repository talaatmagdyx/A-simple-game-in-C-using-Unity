using UnityEngine;
using System.Collections;

public class LooseLifeLevel1 : MonoBehaviour 
{
	public GameObject player;

	void OnTriggerEnter(Collider Col) //On collision event
	{
		if(Col.tag == "Player")
		{
			player.GetComponent<HealthControllerLevel1>().lifeCounter--; //Find the player with the component "HealthControllerLevel1" and run the "LifeCounter" variable.
			player.GetComponent<HealthControllerLevel1>().Respawn(); //Find the player with the component "HealthControllerLevel1" and call the "Respawn" function.
		}
	}
}
