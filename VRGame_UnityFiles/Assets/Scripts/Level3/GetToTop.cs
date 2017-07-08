using UnityEngine;
using System.Collections;

public class GetToTop : MonoBehaviour 
{
	void OnTriggerEnter(Collider Col)
	{
		if(Col.tag == "Player")
		{
			Application.LoadLevel("MainMenu");
		}
	}
}
