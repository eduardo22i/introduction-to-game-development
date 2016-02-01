using UnityEngine;
using System.Collections;

public class PlayerHit : MonoBehaviour {

	public GameObject playerHitPanel;
	private float hideAfterSeconds = 1f;

	// when collided with another gameObject
	void OnCollisionEnter (Collision newCollision)
	{
		if (newCollision.gameObject.tag == "Projectile") {
			
			if (playerHitPanel) {
				playerHitPanel.SetActive (true);

				Invoke ("RemoveRedPanel", hideAfterSeconds);
			}
		}

	}

	void RemoveRedPanel () {
		playerHitPanel.SetActive (false);
	}

}
