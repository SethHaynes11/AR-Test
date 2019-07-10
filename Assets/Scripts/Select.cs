using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Select : MonoBehaviour
{
    public List<int> pointClouds = new List<int>();

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Game")
        {
            pointClouds.Add(Random.Range(0, 4));
            Debug.Log("Game Scene Active");
        }
        else
        {
            Debug.Log("Error");
        }
       
    }


}
