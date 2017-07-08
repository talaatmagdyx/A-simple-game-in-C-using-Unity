using UnityEngine;
using System.Collections;

public class CollectBlue : MonoBehaviour 
{
	public GameObject player;

	void OnTriggerEnter(Collider Col)
	{
		if(Col.tag == "Player")
		{
			player.GetComponent<ScoreController>().blueCube = true;
			this.gameObject.GetComponent<MeshRenderer>().enabled = false;
		}
	}
}
