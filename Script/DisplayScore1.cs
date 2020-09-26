using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore1: MonoBehaviour
{
    /*public int increaseCoin = 1;*/
    public Text cointText;

    //ชนโดยใช้ทริกเกอร์ไม่นับฟิสิกส์


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player");
        {
            //CoinData.coin += increaseCoin;
            cointText.text = CoinData.coin.ToString();
            if(CoinData.coin == 20)
            {
                print("LevelComplete");
                string Sum = Score(CoinData.coin);
                print("Your Score is" + Sum);
                StartCoroutine(Win());              
            }
        }
    }

    //หน่วงเวลาชนะเกม
    IEnumerator Win()
    {
        if (CoinData.coin == 20)
        {
            yield return new WaitForSeconds(2);
            Time.timeScale = 0;
        }
    }

    //รับค่าเหรียญส่งไปปรินท์
    string Score(float Coin)
    {
        Coin = CoinData.coin;
        return Coin.ToString();
    }

}
