using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;


//Fetch http://localhost

public class FetchWebsite : MonoBehaviour
{
    public List<string> pointCloud = new List<string>();
    int randomInt;
    public string selected;

    void Start()
    {
        // A correct website page.
        StartCoroutine(GetRequest("http://localhost"));

        // A non-existing page.
        StartCoroutine(GetRequest("https://error.html"));
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                randomInt = Random.Range(0, pointCloud.Count);
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                
                selected = webRequest.downloadHandler.text;
                
                Debug.Log(selected[1]);
            }
        }
    }
}
