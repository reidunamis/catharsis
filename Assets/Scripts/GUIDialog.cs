using UnityEngine;
using System.Collections;

public class GUIDialog : MonoBehaviour {
	
	public string stringToEdit = "hum hum ...";
	
	void OnGUI() {
        stringToEdit = GUI.TextField(new Rect(10, 10, 200, 20), stringToEdit, 25);
    }
}
