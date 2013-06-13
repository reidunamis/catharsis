using UnityEngine;
using System.Collections;

public class ControlHero : MonoBehaviour {
float  speed = 0.75f;
float jumpSpeed = 2f;
Vector3 moveDirection;
RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
    	moveDirection = InputPC();
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        
        transform.position += moveDirection* Time.deltaTime;
		
		Interagir();
	}
	
	Vector3 InputPC() 
	{
		if(Input.GetAxis("Horizontal")<0 && Input.GetAxis("Vertical")>0)
		{
			transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
			transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "up_left");
			transform.rotation = Quaternion.Euler(0,0,0);
			return Vector3.forward;
			//return Vector3(0,0,1);
		}
		else if(Input.GetAxis("Horizontal")<0 && Input.GetAxis("Vertical")<0)
		{
			transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
			transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "down_left");
			transform.rotation = Quaternion.Euler(0,-90,0);
			return Vector3.forward;
			//return Vector3(-1,0,0);
		}
		else if(Input.GetAxis("Horizontal")>0 && Input.GetAxis("Vertical")>0)
		{
			transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
			transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "up_right");
			transform.rotation = Quaternion.Euler(0,90,0);
			return Vector3.forward;
			//return Vector3(1,0,0);
		}
		else if(Input.GetAxis("Horizontal")>0 && Input.GetAxis("Vertical")<0)
		{
			transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
			transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "down_right");
			transform.rotation = Quaternion.Euler(0,-180,0);
			return Vector3.forward;
			//return Vector3(0,0,-1);
		}
		else if(Input.GetAxis("Vertical")<0)
		{
			transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
			transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "down");
			transform.rotation = Quaternion.Euler(0,-135,0);
			return Vector3.forward;
			//return  Vector3(-1 ,0,-1);
		}
		else if(Input.GetAxis("Vertical")>0)
		{
			transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
			transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "up");
			transform.rotation = Quaternion.Euler(0,45,0);
			return Vector3.forward;
			//return Vector3(1 ,0,1);
		}
		else if(Input.GetAxis("Horizontal")>0)
		{
			transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
			transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "right");
			transform.rotation = Quaternion.Euler(0,135,0);
			return Vector3.forward;
			//return Vector3(1 ,0,-1);
		}
		else if(Input.GetAxis("Horizontal")<0)
		{
			transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "walk");
			transform.Find("Apparence").Find("Sprite").SendMessage("setDirection", "left");
			transform.rotation = Quaternion.Euler(0,-45,0);
			return Vector3.forward;
			//return Vector3(-1 ,0,1);
		}
		else
		{
			//On stand
			transform.Find("Apparence").Find("Sprite").SendMessage("setAction", "stand");
			return new Vector3(0,0,0);
		}			
	}
	
	void Interagir()
	{
		if(Input.GetButtonUp("Fire1"))
		{
			hit = new RaycastHit();
			Vector3 fwd = transform.TransformDirection(Vector3.forward);
			Vector3 rayFrom = new Vector3(	transform.position.x, 
											transform.position.y + 0.05f, 
											transform.position.z);
	        if (Physics.Raycast(rayFrom, fwd, out hit, 0.1f))
			{
	            //Debug.Log ("On touche !");
				GameObject go = GameObject.Find("Main");
				hit.collider.SendMessage("Reagir");
				//GUIDialog.stringToEdit = "On touche !";
			}
			else
			{				
	            //Debug.Log ("On touche rien ...");	
				GameObject go = GameObject.Find("Main");
				go.GetComponent<GUIDialog>().stringToEdit = "On touche rien ...";
				//GUIDialog.stringToEdit = "On touche rien ...";
			}
		}
	}
}
