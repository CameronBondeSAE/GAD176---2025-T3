using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DefaultNamespace
{
	public class PlayerController : MonoBehaviour
	{
		public Inventory inventory;
		
		private void Update()
		{
			if (InputSystem.GetDevice<Keyboard>().fKey.wasPressedThisFrame)
			{
				inventory.UseItem();
			}

			if (InputSystem.GetDevice<Keyboard>().eKey.wasPressedThisFrame)
			{
				inventory.NextItem();
			}
		}
	}
}