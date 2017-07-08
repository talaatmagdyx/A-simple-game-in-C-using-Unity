using UnityEngine;
using System.Collections;

public class CollectRed : MonoBehaviour 
{
	public GameObject player;

	void OnTriggerEnter(Collider Col)
	{
		if(Col.tag == "Player")
		{
			player.GetComponent<ScoreController>().redCube = true;
			this.gameObject.GetComponent<MeshRenderer>().enabled = false;
		}
	}
}
