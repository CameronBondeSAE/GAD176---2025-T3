using System;
using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
	public UnityEvent onGoal;

	private void OnTriggerEnter(Collider other)
	{
		onGoal.Invoke();
	}
}
