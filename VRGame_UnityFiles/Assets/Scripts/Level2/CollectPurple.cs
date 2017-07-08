using UnityEngine;
using System.Collections;

public class CollectPurple : MonoBehaviour 
{
	public GameObject player;

	void OnTriggerEnter(Collider Col)
	{
		if(Col.tag == "Player")
		{
			player.GetComponent<ScoreController>().purpleCube = true;
			this.gameObject.GetComponent<MeshRenderer>().enabled = false;
		}
	}
}
