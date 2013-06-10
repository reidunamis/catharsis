using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	
	GameObject theHero;
		
	// Update is called once per frame
	void Update () {
		theHero = GameObject.FindWithTag("Player");
		Vector3 positionCamera = new Vector3(theHero.transform.position.x-0.3f, theHero.transform.position.y+0.5f, theHero.transform.position.z-0.3f);
		transform.position = positionCamera;
	}
}
