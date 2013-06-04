using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Principal : MonoBehaviour {
	
	public Dictionary<int, Personnage> personnages;
	
	void Awake () {
        DontDestroyOnLoad (transform.gameObject);
    }
	
	// Use this for initialization
	void Start () {
		personnages = new Dictionary<int, Personnage>();
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
		personnages.Add(0,kojiro);
		personnages.Add(1,manon);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}


