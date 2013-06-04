#pragma strict
var theHero : GameObject;

function Update () {
	transform.position.x = theHero.transform.position.x-0.3;
	transform.position.y = theHero.transform.position.y+0.5;
	transform.position.z = theHero.transform.position.z-0.3;
	
}