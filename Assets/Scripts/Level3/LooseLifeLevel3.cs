using UnityEngine;
using System.Collections;

public class LooseLifeLevel3 : MonoBehaviour 
{
	public GameObject player;

	void OnTriggerEnter(Collider Col)
	{
		if(Col.tag == "Player")
		{
			player.GetComponent<HealthControllerLevel3>().lifeCounter--;
			player.GetComponent<HealthControllerLevel3>().Respawn();
		}
	}
}
