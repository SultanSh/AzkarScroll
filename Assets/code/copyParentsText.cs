using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class copyParentsText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Text ptext = transform.parent.GetComponentInParent<Transform>().GetComponentInParent<Text>();
        print(ptext.text);
        gameObject.GetComponent<Text>().text = ptext.text;
	}
}
