using UnityEngine;
using System.Collections;

public class LooseLifeLevel1 : MonoBehaviour 
{
	public GameObject player;

	void OnTriggerEnter(Collider Col)
	{
		if(Col.tag == "Player")
		{
			player.GetComponent<HealthControllerLevel1>().lifeCounter--;
			player.GetComponent<HealthControllerLevel1>().Respawn();
		}
	}
}
