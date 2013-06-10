using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class menuStatus : MonoBehaviour {
	
	int idPersonnage;
	Dictionary<int, Personnage> listPersonnage;
	Dictionary<int, int> equipe;
	public Texture artManon;
	// Use this for initialization
	void Awake () {
		idPersonnage = 0;
		
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		listPersonnage = gameObject.GetComponent<Principal>().personnages;
		equipe = gameObject.GetComponent<Principal>().equipe;
		if(Input.GetKey("left"))
		{
			if(equipe.ContainsKey(idPersonnage - 1))
			{
				idPersonnage -= 1;
			}
		}
		else if(Input.GetKey("right"))
		{
			if(equipe.ContainsKey(idPersonnage + 1))
			{
				idPersonnage += 1;
			}
		}
		transform.Find("Status").Find("nomPrenom").guiText.text			= listPersonnage[equipe[idPersonnage]].prenom;
		transform.Find("Status").Find("Niveau").guiText.text 			= "Niveau " + listPersonnage[equipe[idPersonnage]].niveau;
		transform.Find("Status").Find("HP").guiText.text 				= "HP - " + listPersonnage[equipe[idPersonnage]].HPactuel + "/" + listPersonnage[idPersonnage].HPtotaux;
		transform.Find("Status").Find("MP").guiText.text 				= "MP - " + listPersonnage[equipe[idPersonnage]].MPactuel + "/" + listPersonnage[idPersonnage].MPtotaux;
		transform.Find("Status").Find("Force").guiText.text 			= "Force - " + listPersonnage[equipe[idPersonnage]].force;
		transform.Find("Status").Find("Defense").guiText.text 			= "Defense - " + listPersonnage[equipe[idPersonnage]].defense;
		transform.Find("Status").Find("Magie").guiText.text 			= "Magie - " + listPersonnage[equipe[idPersonnage]].magie;
		transform.Find("Status").Find("defenseMagie").guiText.text		= "Defense magique - " + listPersonnage[equipe[idPersonnage]].defenseMagique;
		transform.Find("Status").Find("souplesse").guiText.text 		= "Souplesse - " + listPersonnage[equipe[idPersonnage]].souplesse;
		
		switch (listPersonnage[equipe[idPersonnage]].nomCode)
		{
		    case "manon": 
				transform.Find("Status").Find("art").guiTexture.pixelInset.Set(0,0,512,512);
				transform.Find("Status").Find("art").guiTexture.texture = artManon;
		        break;
		    default:
		        break;
		}
	}
}
