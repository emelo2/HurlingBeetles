using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyInstructionScript : MonoBehaviour {

	public Image image;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("e"))
			Destroy (image.gameObject);
	}
}
