using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    void Start()
    {
        Debug.Log("MurrMeow");
    }
	void FixedUpdate () {
        this.gameObject.GetComponent<Renderer>().material.SetColor("_Color",Random.ColorHSV());
	}
}
