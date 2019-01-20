using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addTweetsPeriodically : MonoBehaviour {
    public GameObject tweetManager;
    int firstFrame;
	// Use this for initialization
	void Start () {
        firstFrame = Time.frameCount;
	}
	
	// Update is called once per frame
	void Update () {
        if (((Time.frameCount-firstFrame)%100 == 0) && (Time.frameCount - firstFrame)>0)
        {
//            print("hi");
            tweetManager.GetComponent<createAndArrangeButtons>().addNewTweet("Mr. Me", ""+(Time.frameCount - firstFrame) );
        }   
	}
}
