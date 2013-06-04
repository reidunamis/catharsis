#pragma strict

var speed : float = 0.75;
var jumpSpeed : float = 2;
var gravity : float = 10.0;
private var moveDirection : Vector3 = Vector3.zero;
function Update() {

	//InputPC();
    var controller : CharacterController = GetComponent(CharacterController);
    if (controller.isGrounded) {
        // We are grounded, so recalculate
        // move direction directly from axes
        moveDirection = InputPC();
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        
        if (Input.GetButton ("Jump")) {
            moveDirection.y = jumpSpeed;
        }
    }
    // Apply gravity
    moveDirection.y -= gravity * Time.deltaTime;
    
    // Move the controller
    controller.Move(moveDirection * Time.deltaTime);
}


function InputPC() 
{
//deplacement
	/*if(Input.GetKey("left"))
	{
		transform.position += Vector3(-1*Time.deltaTime*speed ,0,1*Time.deltaTime*speed);
	}
	else if(Input.GetKey("right"))
	{
		transform.position += Vector3(1*Time.deltaTime*speed ,0,-1*Time.deltaTime*speed);
	}
	
	if(Input.GetKey("up"))
	{
		transform.position += Vector3(1*Time.deltaTime*speed ,0,1*Time.deltaTime*speed);
	}
	else if(Input.GetKey("down"))
	{
		transform.position += Vector3(-1*Time.deltaTime*speed ,0,-1*Time.deltaTime*speed);
	}*/
	if(Input.GetKey("left") && Input.GetKey("up"))
	{
		transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
		transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "up_left");
		return Vector3(0,0,1);
	}
	else if(Input.GetKey("left") && Input.GetKey("down"))
	{
		transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
		transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "down_left");
		return Vector3(-1,0,0);
	}
	else if(Input.GetKey("right") && Input.GetKey("up"))
	{
		transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
		transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "up_right");
		return Vector3(1,0,0);
	}
	else if(Input.GetKey("right") && Input.GetKey("down"))
	{
		transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
		transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "down_right");
		return Vector3(0,0,-1);
	}
	else if(Input.GetKey("down"))
	{
		transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
		transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "down");
		return  Vector3(-1 ,0,-1);
	}
	else if(Input.GetKey("up"))
	{
		transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
		transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "up");
		return Vector3(1 ,0,1);
	}
	else if(Input.GetKey("right"))
	{
		transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
		transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "right");
		return Vector3(1 ,0,-1);
	}
	else if(Input.GetKey("left"))
	{
		transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
		transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "left");
		return Vector3(-1 ,0,1);
	}
	else
	{
		//On stand
		transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "stand");
		return Vector3(0,0,0);
	}
	
	
}