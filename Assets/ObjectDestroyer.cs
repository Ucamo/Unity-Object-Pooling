using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public void OnCollisionEnter(Collision obj) {
		obj.gameObject.SetActive(false);
	}
}
