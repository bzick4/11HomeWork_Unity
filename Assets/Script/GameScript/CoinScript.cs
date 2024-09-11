using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coin;
    private int totalCoin;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Debug.Log("jjjjj");
            totalCoin++;
            Destroy(other.gameObject);
        }
    }
    
    private void Update()
    {
        _coin.text = totalCoin.ToString();
    }

}
