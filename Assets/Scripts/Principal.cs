using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Principal : MonoBehaviour {
	
	public Dictionary<int, Personnage> personnages;
	public Dictionary<int, int> equipe;
	
	void Awake () {
        DontDestroyOnLoad (transform.gameObject);
    }
	
	// Use this for initialization
	void Start () {
		personnages = new Dictionary<int, Personnage>();
		equipe = new Dictionary<int, int>();
		Personnage kojiro = new Personnage("Nagueru",
				"Kojiro",
				100,
				20,
				7,
				5,
				3,
				5,
				5,
				"kojiro");
		Personnage manon = new Personnage("Uldgeon",
				"Manon",
				80,
				30,
				5,
				3,
				7,
				6,
				5,
				"manon");
		Personnage karaz = new Personnage("Crossweith",
				"Karaz",
				90,
				15,
				9,
				5,
				2,
				4,
				5,
				"karaz");
		personnages.Add(0,kojiro);
		personnages.Add(1,manon);
		personnages.Add(2,karaz);
		equipe.Add (0,0);
		equipe.Add (1,1);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}


