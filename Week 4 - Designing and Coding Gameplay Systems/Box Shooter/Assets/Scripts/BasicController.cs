using UnityEngine;
using System.Collections;

public class BasicController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Horizantal Input = " + Input.GetAxis ("Horizontal"));

	}
}
