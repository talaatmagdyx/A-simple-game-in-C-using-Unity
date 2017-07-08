using UnityEngine;
using System.Collections;

public class CompleteLevel2 : MonoBehaviour 
{
	void OnTriggerEnter(Collider Col)
	{
		if(Col.tag == "Player")
		{
			Application.LoadLevel("ToLevel3");
		}
	}
}
