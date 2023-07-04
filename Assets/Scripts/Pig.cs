using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour 
{
	public GameController enemy;
	private void OnCollisionEnter(Collision other) 
	{
		if(other.gameObject.tag == "bullet")
		{
			Destroy(this.gameObject);
			enemy.L1_enemy -= 1;
		}
	}
}
