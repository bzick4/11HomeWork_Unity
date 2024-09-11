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
        if (other.gameObject.GetComponent<BallWalk>() !=null)
        {
            Debug.Log("jjjjj");
            totalCoin++;
            Destroy(other.gameObject);
            Text();
        }
    }
    
    private void Text()
    {
        _coin.text = totalCoin.ToString();
    }

}
