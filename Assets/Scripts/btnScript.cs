using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnScript : MonoBehaviour
{

    

    public void Play()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void Rate()
    {
        Application.OpenURL("market://details?id=com.SmpleGames.TriangleSwiper");
    }


}