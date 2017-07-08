using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour 
{
	public bool quitButton = false;
	public GameObject button;

	public Material normalTex;
	public Material hoverTex;

	public AudioClip clickSound;

	void Start()
	{
		button.GetComponent<Renderer>().material = normalTex;
	}

	void OnMouseEnter()
	{
		GetComponent<AudioSource>().PlayOneShot(clickSound);
		button.GetComponent<Renderer>().material = hoverTex;
	}

	void OnMouseExit()
	{
		GetComponent<AudioSource>().Stop ();
		button.GetComponent<Renderer>().material = normalTex;
	}

	void OnMouseUp()
	{
		if(quitButton)
		{
			Application.Quit();
		}

		else
		{
			Application.LoadLevel ("Level1");
		}
	}
}












