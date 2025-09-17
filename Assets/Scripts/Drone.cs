using UnityEngine;

public class Drone : MonoBehaviour, IUsable
{

	public void StartFlying()
	{
		Debug.Log("Start Flying");
	}

	public void Use()
	{
		StartFlying();
	}
}
