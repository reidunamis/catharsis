using UnityEngine;
using System.Collections;

public class Principal : MonoBehaviour {
	
	public ArrayList personnages;
	
	void Awake () {
        DontDestroyOnLoad (transform.gameObject);
    }
	
	// Use this for initialization
	void Start () {
		personnages = new ArrayList();
		Personnage kojiro = new Personnage("Nagueru",
				"Kojiro",
				100,
				20,
				7,
				5,
				3,
				5,
				5,
				"kojiro",
				"stand");
		Personnage manon = new Personnage("Uldgeon",
				"Manon",
				80,
				30,
				5,
				3,
				7,
				6,
				5,
				"manon",
				"stand");
		personnages.Add(kojiro);
		personnages.Add(manon);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}


