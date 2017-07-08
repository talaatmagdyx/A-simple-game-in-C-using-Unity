using UnityEngine;
using System.Collections;

public class CompleteLevel1 : MonoBehaviour 
{
	void OnTriggerEnter(Collider Col)
	{
		if(Col.tag == "Player")
		{
			Application.LoadLevel("ToLevel2");
		}
	}
}
