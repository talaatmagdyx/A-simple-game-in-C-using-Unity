using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour 
{
	void Awake()
	{
		DontDestroyOnLoad(gameObject); //Don't destroy the gameobject when we move scenes
	}
}
