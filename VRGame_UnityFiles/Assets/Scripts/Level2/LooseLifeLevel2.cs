using UnityEngine;
using System.Collections;

public class LooseLifeLevel2 : MonoBehaviour 
{
	public GameObject player;

	void OnTriggerEnter(Collider Col)
	{
		if(Col.tag == "Player")
		{
			player.GetComponent<HealthControllerLevel2>().lifeCounter--;
			player.GetComponent<HealthControllerLevel2>().Respawn();
		}
	}
}
