using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{

	public Vector3 targetPos;
	public Vector3 lowerdPos;

	void Start () 
	{
		targetPos = transform.localPosition;
	}

	private void Update() 
	{
		transform.localPosition = Vector3.Lerp(
			transform.localPosition,
			targetPos,
			Time.deltaTime
		);
	}

	[ContextMenu("開門")]
	public void LowerDoor()
	{
		targetPos = lowerdPos;
	}
}
