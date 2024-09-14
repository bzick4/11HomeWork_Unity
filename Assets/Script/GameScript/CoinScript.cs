using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coin;
    public int totalCoin { get; private set;}
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BallWalk>() !=null)
        {
            totalCoin++;
            DestroyCoin();
            Text();
        }
    }
    
    private void Text()
    {
        _coin.text = totalCoin.ToString();
    }

    private void DestroyCoin()
    {
        Destroy(gameObject.transform.parent.gameObject);
    }
    
}
