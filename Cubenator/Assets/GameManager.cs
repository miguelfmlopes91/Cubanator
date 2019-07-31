using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float transition = 1f;
    bool gameHasEnded;
   public void EndGame(){
       if (gameHasEnded == false)
       {
            gameHasEnded = true;
            Debug.Log("Game has ended");
            Invoke("Restart",transition);
       }
   }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
