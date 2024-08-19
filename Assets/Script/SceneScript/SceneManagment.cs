using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RestartScene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (other.CompareTag("NextLevel"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } 
        
        if (other.CompareTag("Level1"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
        
        if (other.CompareTag("Level2"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
        }
        
        if (other.CompareTag("Level3"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
        }
        
        if (other.CompareTag("Level4"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+4);
        }
        
        if (other.CompareTag("Level5"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+5);
        }
    }
}
