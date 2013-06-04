#pragma strict
var theHeroApparence : GameObject;
//var sprite : GameObject;


private var laCamera:Transform;
private var versCamera:Vector3;



private var uvAnimationTileX = 1; //Here you can place the number of columns of your sheet. 
                           //The above sheet has 24
 
private var uvAnimationTileY = 1; //Here you can place the number of rows of your sheet. 
                          //The above sheet has 1
var framesPerSecond = 7.0;

var stand_up:Texture;
var stand_down:Texture;
var stand_right:Texture;
var stand_left:Texture;
var stand_up_left:Texture;
var stand_up_right:Texture;
var stand_down_left:Texture;
var stand_down_right:Texture;

var walk_up:Texture;
var walk_down:Texture;
var walk_right:Texture;
var walk_left:Texture;
var walk_up_left:Texture;
var walk_up_right:Texture;
var walk_down_left:Texture;
var walk_down_right:Texture;


private var direction:String = "down";
private var action:String = "stand";

function Start () {
	
	laCamera = GameObject.Find("Camera").transform;

}
 
function Update () 
{
	//Debug.Log("Direction : " + direction + " Action : " + action );
 
	versCamera = laCamera.position - theHeroApparence.transform.position;
	theHeroApparence.transform.rotation = Quaternion.LookRotation(versCamera);
	
	
	// Calculate index
	var index : int = Time.time * framesPerSecond;
	// repeat when exhausting all frames
	index = index % (uvAnimationTileX * uvAnimationTileY);
 
	// Size of every tile
	var size = Vector2 (1.0 / uvAnimationTileX, 1.0 / uvAnimationTileY);
 
	// split into horizontal and vertical index
	var uIndex = index % uvAnimationTileX;
	var vIndex = index / uvAnimationTileX;
 
	// build offset
	// v coordinate is the bottom of the image in opengl so we need to invert.
	var offset = Vector2 (uIndex * size.x, 1.0 - size.y - vIndex * size.y);
 	
 	renderer.material.SetTexture ("_MainTex", setAnimTexture(direction, action));
	renderer.material.SetTextureScale ("_MainTex", size);
	renderer.material.SetTextureOffset ("_MainTex", offset); 
}

public function setDirection(newDirection : String)
{
	direction = newDirection;
}
public function setAction(newAction : String)
{
	action = newAction;
}

function setAnimTexture(uneDirection, uneAction)
{
	switch (uneDirection)
 	{
 		case "up":
			switch (uneAction)
		 	{
		 		case "walk":
					uvAnimationTileX = 5;
					uvAnimationTileY = 1;
					return walk_up;
					break;
		 		case "stand":
					uvAnimationTileX = 1;
					uvAnimationTileY = 1;
					return stand_up;
					break;
		 	
		 	}
			break;
 		case "down":
			switch (uneAction)
		 	{
		 		case "walk":
					uvAnimationTileX = 5;
					uvAnimationTileY = 1;
					return walk_down;
					break;
		 		case "stand":
					uvAnimationTileX = 1;
					uvAnimationTileY = 1;
					return stand_down;
					break;
		 	
		 	}
			break;
 		case "left":
			switch (uneAction)
		 	{
		 		case "walk":
					uvAnimationTileX = 5;
					uvAnimationTileY = 1;
					return walk_left;
					break;
		 		case "stand":
					uvAnimationTileX = 1;
					uvAnimationTileY = 1;
					return stand_left;
					break;
		 	
		 	}
			break;
 		case "right":
			switch (uneAction)
		 	{
		 		case "walk":
					uvAnimationTileX = 5;
					uvAnimationTileY = 1;
					return walk_right;
					break;
		 		case "stand":
					uvAnimationTileX = 1;
					uvAnimationTileY = 1;
					return stand_right;
					break;
		 	
		 	}
			break;
 		case "up_left":
			switch (uneAction)
		 	{
		 		case "walk":
					uvAnimationTileX = 5;
					uvAnimationTileY = 1;
					return walk_up_left;
					break;
		 		case "stand":
					uvAnimationTileX = 1;
					uvAnimationTileY = 1;
					return stand_up_left;
					break;
		 	
		 	}
			break;
 		case "up_right":
			switch (uneAction)
		 	{
		 		case "walk":
					uvAnimationTileX = 5;
					uvAnimationTileY = 1;
					return  walk_up_right;
					break;
		 		case "stand":
					uvAnimationTileX = 1;
					uvAnimationTileY = 1;
					return stand_up_right;
					break;
		 	
		 	}
			break;
 		case "down_right":
			switch (uneAction)
		 	{
		 		case "walk":
					uvAnimationTileX = 5;
					uvAnimationTileY = 1;
					return  walk_down_right;
					break;
		 		case "stand":
					uvAnimationTileX = 1;
					uvAnimationTileY = 1;
					return stand_down_right;
					break;
		 	
		 	}
			break;
 		case "down_left":
			switch (uneAction)
		 	{
		 		case "walk":
					uvAnimationTileX = 5;
					uvAnimationTileY = 1;
					return walk_down_left;
					break;
		 		case "stand":
					uvAnimationTileX = 1;
					uvAnimationTileY = 1;
					return stand_down_left;
					break;
		 	
		 	}
			break;
 	
 	}
}