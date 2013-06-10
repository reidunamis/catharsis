using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class apparenceHeros : MonoBehaviour {
	
	Transform laCamera;
	public GameObject theHeroApparence;
	string direction;
	string action;
	public float fps = 15f;
	int frameEnCours = 1;
	Dictionary<int, Vector2> animEnCours;
	
	// Use this for initialization
	void Start () {
		animEnCours = new Dictionary<int, Vector2>();
		
		animEnCours.Add(0, new Vector2(0.0f,6.0f));
		animEnCours.Add(1, new Vector2(1.0f,6.0f));
		animEnCours.Add(2, new Vector2(2.0f,6.0f));
		animEnCours.Add(3, new Vector2(3.0f,6.0f));
		animEnCours.Add(4, new Vector2(4.0f,6.0f));
		
		
		direction = "down";
		action = "stand";
		laCamera = GameObject.Find("Camera").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rotationCamera = laCamera.rotation.eulerAngles;
		rotationCamera = new Vector3(-rotationCamera.x, rotationCamera.y - 180 ,rotationCamera.z);
		theHeroApparence.transform.rotation = Quaternion.Euler(rotationCamera);
				
		
		setAnimTexture(direction, action);
		//Debug.Log (direction + " - " + action);
		float index0 = Time.time * fps;
		int index = (int)(index0 % animEnCours.Count);
		frameEnCours = index;
		
		
		/*if(animEnCours.ContainsKey(frameEnCours + 1))
		{
			frameEnCours += 1;
		}
		else
		{
			frameEnCours = 1;
		}*/
		
		
		Vector2 offset = new Vector2 (animEnCours[frameEnCours].x * 0.125f, animEnCours[frameEnCours].y * 0.125f);
		//Vector2 offset = new Vector2 (2.0f * 0.125f, 7.0f *0.125f);
		renderer.material.SetTextureOffset ("_MainTex", offset);
		
	}
	
	void setDirection(string newDirection)
	{
		direction = newDirection;
	}
	void setAction(string newAction)
	{
		action = newAction;
	}
	
	void setAnimTexture(string uneDirection, string uneAction)
	{
		switch (uneDirection)
	 	{
	 		case "up":
				switch (uneAction)
			 	{
			 		case "walk":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(1.0f,3.0f));
						animEnCours.Add(1, new Vector2(2.0f,3.0f));
						animEnCours.Add(2, new Vector2(3.0f,3.0f));
						animEnCours.Add(3, new Vector2(4.0f,3.0f));
						animEnCours.Add(4, new Vector2(5.0f,3.0f));
						break;
			 		case "stand":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(7.0f,7.0f));
						break;
			 	
			 	}
				break;
	 		case "down":
				switch (uneAction)
			 	{
			 		case "walk":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(0.0f,6.0f));
						animEnCours.Add(1, new Vector2(1.0f,6.0f));
						animEnCours.Add(2, new Vector2(2.0f,6.0f));
						animEnCours.Add(3, new Vector2(3.0f,6.0f));
						animEnCours.Add(4, new Vector2(4.0f,6.0f));
						break;
			 		case "stand":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(2.0f,7.0f));
						break;
			 	
			 	}
				break;
	 		case "left":
				switch (uneAction)
			 	{
			 		case "walk":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(7.0f,5.0f));
						animEnCours.Add(1, new Vector2(0.0f,4.0f));
						animEnCours.Add(2, new Vector2(1.0f,4.0f));
						animEnCours.Add(3, new Vector2(2.0f,4.0f));
						animEnCours.Add(4, new Vector2(3.0f,4.0f));
						break;
			 		case "stand":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(3.0f,7.0f));
						break;
			 	
			 	}
				break;
	 		case "right":
				switch (uneAction)
			 	{
			 		case "walk":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(4.0f,4.0f));
						animEnCours.Add(1, new Vector2(5.0f,4.0f));
						animEnCours.Add(2, new Vector2(6.0f,4.0f));
						animEnCours.Add(3, new Vector2(7.0f,4.0f));
						animEnCours.Add(4, new Vector2(0.0f,3.0f));
						break;
			 		case "stand":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(4.0f,7.0f));
						break;
			 	
			 	}
				break;
	 		case "up_left":
				switch (uneAction)
			 	{
			 		case "walk":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(6.0f,3.0f));
						animEnCours.Add(1, new Vector2(7.0f,3.0f));
						animEnCours.Add(2, new Vector2(0.0f,2.0f));
						animEnCours.Add(3, new Vector2(1.0f,2.0f));
						animEnCours.Add(4, new Vector2(2.0f,2.0f));
						break;
			 		case "stand":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(5.0f,7.0f));
						break;
			 	
			 	}
				break;
	 		case "up_right":
				switch (uneAction)
			 	{
			 		case "walk":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(3.0f,2.0f));
						animEnCours.Add(1, new Vector2(4.0f,2.0f));
						animEnCours.Add(2, new Vector2(5.0f,2.0f));
						animEnCours.Add(3, new Vector2(6.0f,2.0f));
						animEnCours.Add(4, new Vector2(7.0f,2.0f));
						break;
			 		case "stand":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(6.0f,7.0f));
						break;
			 	
			 	}
				break;
	 		case "down_right":
				switch (uneAction)
			 	{
			 		case "walk":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(2.0f,5.0f));
						animEnCours.Add(1, new Vector2(3.0f,5.0f));
						animEnCours.Add(2, new Vector2(4.0f,5.0f));
						animEnCours.Add(3, new Vector2(5.0f,5.0f));
						animEnCours.Add(4, new Vector2(6.0f,5.0f));
						break;
			 		case "stand":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(1.0f,7.0f));
						break;
			 	
			 	}
				break;
	 		case "down_left":
				switch (uneAction)
			 	{
			 		case "walk":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(5.0f,6.0f));
						animEnCours.Add(1, new Vector2(6.0f,6.0f));
						animEnCours.Add(2, new Vector2(7.0f,6.0f));
						animEnCours.Add(3, new Vector2(0.0f,5.0f));
						animEnCours.Add(4, new Vector2(0.0f,5.0f));
						break;
			 		case "stand":
						animEnCours.Clear();
						animEnCours.Add(0, new Vector2(0.0f,7.0f));
						break;
			 	
			 	}
				break;
	 	
	 	}
	}
}
