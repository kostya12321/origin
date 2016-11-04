using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	void FixedUpdate () {
        this.gameObject.GetComponent<Renderer>().material.SetColor("_Color",Random.ColorHSV());
	}
}
