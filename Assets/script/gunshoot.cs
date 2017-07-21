using UnityEngine;
using System.Collections;

public class gunshoot : MonoBehaviour {
	private Transform playerTransform;
	private RaycastHit hit;
	public float range = 400;

	// Use this for initialization
	void Start () {
		playerTransform = transform.parent;
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Debug.Log ("Shot");

			if (Physics.Raycast (playerTransform.TransformPoint (new Vector2 (Random.Range (-1, 1), Random.Range(-1, 1))), playerTransform.forward, out hit, range)) {
				if (hit.collider.tag == "Enemy") {
					Destroy (hit.transform.gameObject);
					Debug.Log ("shootEnemy");
				}
			}
		}
	}
}