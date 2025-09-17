using UnityEngine;

public class SmokeGrenade : MonoBehaviour, IUsable
{

	public void PullPin()
	{
		Debug.Log("Pull Pin");
	}

	public void Use()
	{
		PullPin();
	}
}
