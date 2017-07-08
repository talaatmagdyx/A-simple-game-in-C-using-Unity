using UnityEngine;
using System.Collections;

public class ToLevel3 : MonoBehaviour 
{
	public bool quitButton = false;
	public GameObject button;

	public Material normalTex;
	public Material hoverTex;

	public AudioClip clickSound;

	void Start()
	{
		button.renderer.material = normalTex;
	}

	void OnMouseEnter()
	{
		audio.PlayOneShot(clickSound);
		button.renderer.material = hoverTex;
	}

	void OnMouseExit()
	{
		audio.Stop ();
		button.renderer.material = normalTex;
	}

	void OnMouseUp()
	{
		if(quitButton)
		{
			Application.Quit();
		}

		else
		{
			Application.LoadLevel ("Level3");
		}
	}
}












