using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class menuStatus : MonoBehaviour {
	
	public int idPersonnage;
	// Use this for initialization
	void Start () {
		idPersonnage = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Dictionary<int, Personnage> listPersonnage = gameObject.GetComponent<Principal>().personnages;
		if(Input.GetKey("left"))
		{
			if(listPersonnage.ContainsKey(idPersonnage - 1))
			{
				idPersonnage -= 1;
			}
		}
		else if(Input.GetKey("right"))
		{
			if(listPersonnage.ContainsKey(idPersonnage + 1))
			{
				idPersonnage += 1;
			}
		}
		transform.Find("nomPrenom").guiText.text = listPersonnage[idPersonnage].prenom + " " + listPersonnage[idPersonnage].nom;
		transform.Find("Niveau").guiText.text = "Niveau " + listPersonnage[idPersonnage].niveau;
		transform.Find("HP").guiText.text = "HP - " + listPersonnage[idPersonnage].HPactuel + "/" + listPersonnage[idPersonnage].HPtotaux;
		transform.Find("MP").guiText.text = "MP - " + listPersonnage[idPersonnage].MPactuel + "/" + listPersonnage[idPersonnage].MPtotaux;
		transform.Find("Force").guiText.text = "Force - " + listPersonnage[idPersonnage].force;
		transform.Find("Defense").guiText.text = "Defense - " + listPersonnage[idPersonnage].defense;
		transform.Find("Magie").guiText.text = "Magie - " + listPersonnage[idPersonnage].magie;
		transform.Find("defenseMagie").guiText.text = "Defense magique - " + listPersonnage[idPersonnage].defenseMagique;
		transform.Find("souplesse").guiText.text = "Souplesse - " + listPersonnage[idPersonnage].souplesse;
	}
}
