using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour 
{
	public Door door;

	public GameController timer;

	private void OnCollisionEnter(Collision other) 
	{
		Debug.Log("摸到門了");
		door.LowerDoor();
		timer.countStart = true;
	}
}
