using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class levelScript : MonoBehaviour {


    Image m_Image;
    public Sprite padlock;

    public GameObject pan1;
    public GameObject pan2;
    public GameObject pan3;
    public GameObject pan4;
    public GameObject pan5;
    public GameObject pan6;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    void Start()
    {
        
        pan1.transform.Find("pan1bot").gameObject.GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("score1" , 0).ToString();
        if (PlayerPrefs.GetFloat("score1", 0) >= 30)
            pan1.GetComponent<Image>().color = new Color32(205, 107, 50, 255);
        if (PlayerPrefs.GetFloat("score1", 0) >= 45)
            pan1.GetComponent<Image>().color = new Color32(192, 192, 192, 255);
        if (PlayerPrefs.GetFloat("score1", 0) >= 60)
            pan1.GetComponent<Image>().color = new Color32(212, 175, 55, 255);

        if (PlayerPrefs.GetInt("UnlockedLevels", 1) >= 2)
        {
            pan2.transform.Find("Image").gameObject.SetActive(false);
            pan2.transform.Find("pan2top").gameObject.SetActive(true);
            pan2.transform.Find("pan2bot").gameObject.SetActive(true);

            if (PlayerPrefs.GetFloat("score2", 0) >= 30)
                pan2.GetComponent<Image>().color = new Color32(205, 107, 50, 255);
            if (PlayerPrefs.GetFloat("score2", 0) >= 45)
                pan2.GetComponent<Image>().color = new Color32(192, 192, 192, 255);
            if (PlayerPrefs.GetFloat("score2", 0) >= 60)
                pan2.GetComponent<Image>().color = new Color32(212, 175, 55, 255);

            pan2.transform.Find("pan2bot").gameObject.GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("score2", 0).ToString();
        }
        if (PlayerPrefs.GetInt("UnlockedLevels", 1) >= 3)
        {
            pan3.transform.Find("Image").gameObject.SetActive(false);
            pan3.transform.Find("pan3top").gameObject.SetActive(true);
            pan3.transform.Find("pan3bot").gameObject.SetActive(true);
            if (PlayerPrefs.GetFloat("score3", 0) >= 30)
                pan3.GetComponent<Image>().color = new Color32(205, 107, 50, 255);
            if (PlayerPrefs.GetFloat("score3", 0) >= 45)
                pan3.GetComponent<Image>().color = new Color32(192, 192, 192, 255);
            if (PlayerPrefs.GetFloat("score3", 0) >= 60)
                pan3.GetComponent<Image>().color = new Color32(212, 175, 55, 255);
            pan3.transform.Find("pan3bot").gameObject.GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("score3",0).ToString();
        }
        if (PlayerPrefs.GetInt("UnlockedLevels", 1) >= 4)
        {
            pan4.transform.Find("Image").gameObject.SetActive(false);
            pan4.transform.Find("pan4top").gameObject.SetActive(true);
            pan4.transform.Find("pan4bot").gameObject.SetActive(true);
            if (PlayerPrefs.GetFloat("score4", 0) >= 30)
                pan4.GetComponent<Image>().color = new Color32(205, 107, 50, 255);
            if (PlayerPrefs.GetFloat("score4", 0) >= 45)
                pan4.GetComponent<Image>().color = new Color32(192, 192, 192, 255);
            if (PlayerPrefs.GetFloat("score4", 0) >= 60)
                pan4.GetComponent<Image>().color = new Color32(212, 175, 55, 255);
            pan4.transform.Find("pan4bot").gameObject.GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("score4", 0).ToString();
        }
        if (PlayerPrefs.GetInt("UnlockedLevels", 1) >= 5)
        {
            pan5.transform.Find("Image").gameObject.SetActive(false);
            pan5.transform.Find("pan5top").gameObject.SetActive(true);
            pan5.transform.Find("pan5bot").gameObject.SetActive(true);
            if (PlayerPrefs.GetFloat("score5", 0) >= 30)
                pan5.GetComponent<Image>().color = new Color32(205, 107, 50, 255);
            if (PlayerPrefs.GetFloat("score5", 0) >= 45)
                pan5.GetComponent<Image>().color = new Color32(192, 192, 192, 255);
            if (PlayerPrefs.GetFloat("score5", 0) >= 60)
                pan5.GetComponent<Image>().color = new Color32(212, 175, 55, 255);
            pan5.transform.Find("pan5bot").gameObject.GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("score5", 0).ToString();
        }
        if (PlayerPrefs.GetInt("UnlockedLevels", 1) >= 6)
        {
            pan6.transform.Find("Image").gameObject.SetActive(false);
            pan6.transform.Find("pan6top").gameObject.SetActive(true);
            pan6.transform.Find("pan6bot").gameObject.SetActive(true);
            if (PlayerPrefs.GetFloat("score6", 0) >= 30)
                pan6.GetComponent<Image>().color = new Color32(205, 107, 50, 255);
            if (PlayerPrefs.GetFloat("score6", 0) >= 45)
                pan6.GetComponent<Image>().color = new Color32(192, 192, 192, 255);
            if (PlayerPrefs.GetFloat("score6", 0) >= 60)
                pan6.GetComponent<Image>().color = new Color32(212, 175, 55, 255);
            pan6.transform.Find("pan6bot").gameObject.GetComponentInChildren<Text>().text = PlayerPrefs.GetFloat("score6", 0).ToString();
        }
    }
    

    public void Level1()
    {
        PlayerPrefs.SetInt("Level", 1);
        SceneManager.LoadScene("Play");
    }
    public void Level2()
    {
        if (PlayerPrefs.GetInt("UnlockedLevels", 1) >= 2)
        {
            PlayerPrefs.SetInt("Level", 2);
            SceneManager.LoadScene("Play");
        }

    }
    public void Level3()
    {
        if (PlayerPrefs.GetInt("UnlockedLevels", 1) >= 3)
        {
            PlayerPrefs.SetInt("Level", 3);
            SceneManager.LoadScene("Play");
        }

    }
    public void Level4()
    {
        if (PlayerPrefs.GetInt("UnlockedLevels", 1) >= 4)
        {
            PlayerPrefs.SetInt("Level", 4);
            SceneManager.LoadScene("Play");
        }

    }
    public void Level5()
    {
        if (PlayerPrefs.GetInt("UnlockedLevels", 1) >= 5)
        {
            PlayerPrefs.SetInt("Level", 5);
            SceneManager.LoadScene("Play");
        }

    }
    public void Level6()
    {
        if (PlayerPrefs.GetInt("UnlockedLevels", 1) >= 6)
        {
            PlayerPrefs.SetInt("Level", 6);
            SceneManager.LoadScene("Play");
        }

    }
}
