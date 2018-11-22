using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestsDrops : MonoBehaviour {

	public GameObject Item;

	// Update is called once per frame
	void Update () {
		
	}

	public void OnDestroy()
	{
		Instantiate (Item, transform.position, Quaternion.identity);
	}

}
