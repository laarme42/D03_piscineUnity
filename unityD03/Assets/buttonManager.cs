using UnityEngine;
using System.Collections;

public class buttonManager : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}

	public void NextLevelButton()
	{
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	public void QuitButton()
	{
		Application.Quit();
	}

	// Update is called once per frame
	void Update () {
	}
}