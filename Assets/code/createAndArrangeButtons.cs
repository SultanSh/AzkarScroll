using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class createAndArrangeButtons : MonoBehaviour {
    int nTweets = 0;
    public int nTweetsAtStart = 2;
    List<GameObject> tweets;
    // Use this for initialization
    void Start() {

        tweets = new List<GameObject>();
        tweets.Add( (GameObject)Instantiate(Resources.Load("suggestedTweet"), transform.position, transform.rotation, gameObject.transform));
        Vector3 temp = new Vector3(tweets[0].GetComponent<RectTransform>().rect.width, tweets[0].GetComponent<RectTransform>().rect.height, 0.0f);
        Rect tempRect = gameObject.GetComponent<RectTransform>().rect;
        nTweets++;
        gameObject.GetComponent<RectTransform>().sizeDelta = temp;
        for (int i = 1; i < nTweetsAtStart; i++)
        {
            addNewTweet("", "#"+i);   
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void addNewTweet(string tName, string tBody)
    {
        Vector2 parentSize = gameObject.GetComponent<RectTransform>().rect.size;
        Vector3 temp = new Vector3(0, parentSize.y, 0);
        tweets.Add((GameObject)Instantiate(Resources.Load("suggestedTweet"), transform.position + temp, transform.rotation, gameObject.transform));
        tweets[nTweets].GetComponentInChildren<Text>().text = tBody;
        temp = temp + new Vector3(0.0f, tweets[nTweets].GetComponent<RectTransform>().rect.height, 0.0f);
        gameObject.GetComponent<RectTransform>().sizeDelta = temp;
        nTweets++;
        //print(tweets.Count);
//        print("" + nTweets);
    }

    public void removeTweet(string tName, string tBody)
    {
        Vector2 parentSize = gameObject.GetComponent<RectTransform>().rect.size;
        Vector3 temp = new Vector3(0, parentSize.y, 0);
        tweets.Add((GameObject)Instantiate(Resources.Load("suggestedTweet"), transform.position + temp, transform.rotation, gameObject.transform));
        tweets[nTweets].GetComponentInChildren<Text>().text = tBody;
        temp = temp + new Vector3(0.0f, tweets[nTweets].GetComponent<RectTransform>().rect.height, 0.0f);
        gameObject.GetComponent<RectTransform>().sizeDelta = temp;
        nTweets++;
 //       print("" + nTweets);
    }
}
