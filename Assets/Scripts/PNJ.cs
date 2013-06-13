using UnityEngine;
using System.Collections;

public class PNJ : MonoBehaviour {
	void Reagir()
	{
		GameObject go = GameObject.Find("Main");
		go.GetComponent<GUIDialog>().stringToEdit = "Hey salut !";
	}
}
