using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectPointCloud : MonoBehaviour
{
    public List<int> pointClouds = new List<int>();


    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Game")
        {
            pointClouds.Add(Random.Range(0, 2));
            Debug.Log("Game Scene Active");
            if (pointClouds.Contains(0))
            {
                Debug.Log("Harley has been chosen");
            }
            else
            {
                Debug.Log("Slimer has been chosen");
            }
        }
        else
        {
            Debug.Log("Error");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
