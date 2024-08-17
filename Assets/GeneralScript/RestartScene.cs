using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RestartScene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
