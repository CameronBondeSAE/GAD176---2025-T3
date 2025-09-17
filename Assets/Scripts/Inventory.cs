using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	public List<GameObject> items;
	public GameObject currentItem;

	[SerializeField]
	private int currentItemIndex;

	public void UseItem()
	{
		// Does the whole GO exist?
		if (currentItem != null)
		{
			// Does this script exist???
			if (currentItem.GetComponent<IUsable>() != null)
			{
				// YES! Run code
				currentItem.GetComponent<IUsable>().Use();
			}
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		// Is there a component that is an "IUsable" item?
		if (other.gameObject.GetComponent<IUsable>() != null)
		{
			items.Add(other.gameObject);
			other.gameObject.SetActive(false);
		}
	}

	public void NextItem()
	{
		if (items.Count == 0)
			return;

		if (items.Count > 1)
		{
			currentItem.gameObject.SetActive(false);
		}
		
		currentItemIndex++;
		if (currentItemIndex >= items.Count)
		{
			currentItemIndex = 0;
		}
		
		currentItem = items[currentItemIndex];
		currentItem.gameObject.SetActive(true);
		currentItem.transform.SetParent(transform);
		currentItem.transform.localPosition = new Vector3(0,0,1f); // Offset in front of player
	}
}