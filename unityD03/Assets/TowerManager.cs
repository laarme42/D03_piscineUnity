using UnityEngine;
using System.Collections;

public class TowerManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public void Drag(){
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Debug.Log (Camera.main.ScreenToWorldPoint(Input.mousePosition));
	}
	// Update is called once per frame
	void Update () {
	
	}
}
