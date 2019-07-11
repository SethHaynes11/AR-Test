using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void SceneLoader(int SceneIndex)
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {

            Permission.RequestUserPermission(Permission.Camera);

        }
        SceneManager.LoadScene(SceneIndex);
    }
}
