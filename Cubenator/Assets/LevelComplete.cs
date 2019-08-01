﻿using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelComplete : MonoBehaviour
{
    public GameManager gameManager;
    public void LoadNextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        gameManager.completeLevelUI.SetActive(false);

    }
}
