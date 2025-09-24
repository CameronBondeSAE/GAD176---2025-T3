using System;
using UnityEngine;

public class Door_Model : MonoBehaviour, IUsable
{
	public Transform doorTransform;

	public void Use()
	{
		doorTransform.Rotate(0,90f,0);
	}
}
