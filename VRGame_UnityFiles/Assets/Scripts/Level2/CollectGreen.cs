using UnityEngine;
using System.Collections;

public class CollectGreen : MonoBehaviour 
{
	public GameObject player;

	void OnTriggerEnter(Collider Col)
	{
		if(Col.tag == "Player")
		{
			player.GetComponent<ScoreController>().greenCube = true;
			this.gameObject.GetComponent<MeshRenderer>().enabled = false;
		}
	}
}
