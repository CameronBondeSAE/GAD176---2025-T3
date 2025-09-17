using UnityEngine;

public class Shield : MonoBehaviour, IUsable
{

	public void ActivateShield()
	{
		Debug.Log("Activate Shield");
	}

	public void Use()
	{
		ActivateShield();
	}
}
