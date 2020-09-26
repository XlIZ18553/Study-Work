using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticCoin : MonoBehaviour
{
    public float increaseCoin;
  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") ;
        {
            CoinData.coin += increaseCoin;
            Destroy(gameObject);
        }
    }

}
