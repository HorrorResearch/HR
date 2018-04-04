using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEventFPS : MonoBehaviour {

	public GameObject inventoryPanel;
	public GameObject[] inventoryIcons;
	public GameObject i1 = null;
	public GameObject i2 = null;
	public GameObject i3 = null;

	public void OnTriggerEnter(Collider other)
	{
		
		if (other.CompareTag ("item1")) 
		{
			Debug.Log ("item1 Collision!");
			i1 = Instantiate(inventoryIcons[0]);
			i1.transform.SetParent(inventoryPanel.transform);
			Destroy (other.gameObject);
		}

		if (other.CompareTag ("item2")) 
		{
			Debug.Log ("item1 Collision!");
			i2 = Instantiate(inventoryIcons[1]);
			i2.transform.SetParent(inventoryPanel.transform);
			Destroy (other.gameObject);
		}

		if (other.CompareTag ("item3")) 
		{
			Debug.Log ("item1 Collision!");
			i3 = Instantiate(inventoryIcons[2]);
			i3.transform.SetParent(inventoryPanel.transform);
			Destroy (other.gameObject);
		}

		if (other.CompareTag ("door1")) 
		{
			Debug.Log ("door1 Collision!");
			Destroy (i1);
		}

		if (other.CompareTag ("door2")) 
		{
			Debug.Log ("door2 Collision!");
			Destroy (i2);
		}

		if (other.CompareTag ("door3")) 
		{
			Debug.Log ("door3 Collision!");
			Destroy (i3);
		}


	}
}
