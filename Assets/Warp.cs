﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    public Transform warpTarget;

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.name == "PlayerPrefab") {
			other.gameObject.transform.position = warpTarget.position;
			Camera.main.transform.position = warpTarget.position;
		}
    }
}
