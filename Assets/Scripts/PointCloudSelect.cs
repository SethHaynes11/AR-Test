using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointCloudSelect : MonoBehaviour
{
    public List<GameObject> pointCloud = new List<GameObject>();

    int randomInt;

    public GameObject selected;
    void Start()
    {
        
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Game")
        {
            Debug.Log("Game Scene Active");
            SelectRandom();
        }
        else
        {
            Debug.Log("Error");
        }
        
    }

    void SelectRandom()
    {
        
        randomInt = Random.Range(0, pointCloud.Count);

        selected = pointCloud[randomInt];

        Debug.Log(selected);
        selected.SetActive(true);


        //Enable one of them, disable rest

        /*if (randomInt.Equals(1))
        {
            Debug.Log("Remove Slimer");
            //gameObject.Equals("Slimer");
            //gameObject.SetActive(false);
        }
        else if (randomInt.Equals(2))
        {
            Debug.Log("Remove Harley");
            //gameObject.Equals("Harley");
            //gameObject.SetActive(false);
            
        }
        else
        {
            Debug.Log("Error");
            
        }*/
        
    }
}
