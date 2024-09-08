using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    [SerializeField] private GameObject _panelWin, _panelLose;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RestartScene"))
        {
            _panelLose.SetActive(true);
        }

        if (other.CompareTag("NextLevel"))
        {
            _panelWin.SetActive(true);
        } 
        
    }
}
