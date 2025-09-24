using System;
using UnityEngine;

public class Switch : MonoBehaviour
{
	public GameObject thingToSwitch;
	
	private void OnCollisionEnter(Collision other)
	{
		thingToSwitch.GetComponent<IUsable>().Use();
	}
}
