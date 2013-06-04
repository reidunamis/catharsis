using UnityEngine;
using System.Collections;

public class Personnage{
	
	//déclaration des variables 
	public string nom;
	public string prenom;
	public int HPtotaux;
	public int MPtotaux;
	public int HPactuel;
	public int MPactuel;
	public int force;
	public int defense;
	public int magie;
	public int defenseMagique;
	public int souplesse;
	public string nomCode;
	public string status;
	public int niveau;
	public int experience;
	
	//constructeur
	public Personnage (string unNom,
				string unPrenom,
				int unHP,
				int unMP,
				int uneForce,
				int uneDefense,
				int uneMagie,
				int uneDefenseMagique,
				int uneSouplesse,
				string unNomCode,
				string unStatus)
	{
		nom = unNom;
		prenom = unPrenom;
		HPtotaux = unHP;
		MPtotaux = unMP;
		HPactuel = unHP;
		MPactuel = unMP;
		force = uneForce;
		defense = uneDefense;
		magie = uneMagie;
		defenseMagique = uneDefenseMagique;
		souplesse = uneSouplesse;
		nomCode= unNomCode;
		status = unStatus;
		niveau = 1;
		experience = 0;
	}
}
