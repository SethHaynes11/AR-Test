using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public void OnMouseDown()
    {
        Debug.Log("Butterfly Clicked");
        gameObject.GetComponent<Animation>().enabled = false;
    }
}
