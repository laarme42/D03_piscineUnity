using UnityEngine;
using System.Collections;

public class TowerManager : MonoBehaviour {
	private GUIText myGUIText;
	public GameObject game;
	// Use this for initialization

	void Start () {
		this.GetComponentInChildren<GUIText> ().text = "toto";
	
	}
	public void Drag(){
		transform.Translate(Camera.main.ScreenToWorldPoint(Input.mousePosition));
		game = (GameObject)GameObject.FindGameObjectWithTag ("game");
		Debug.Log (game.GetComponent<gameManager>().playerEnergy);

	}
	// Update is called once per frame
	void Update () {
		myGUIText = this.GetComponentInChildren<GUIText> ();
		//myGUIText. = "toto";
		myGUIText.color = new Color(1,1,1);
	}
}