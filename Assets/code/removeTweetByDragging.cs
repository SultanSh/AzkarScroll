using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class removeTweetByDragging : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        print(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(eventData.delta.x)>10.0f)
        {
            Destroy(this.gameObject);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }
}
