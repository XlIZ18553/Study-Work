using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    
    [SerializeField] private Text uiText;

    public float timer;
    private bool canCount = true;
    private bool doOnce = false;

    void Update()
    {

        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");
        }

        else if (timer <= 0.0f && !doOnce )
        {
            canCount = false;
            doOnce = true;
            uiText.text = "GAMEOVER";
            timer = 0.0f;
            string WORD = GameOver();
            print(WORD);
            StartCoroutine(CoUpdate());

        }

    }

    string GameOver()
    {
        string word = "GAMEOVER";
        return word;
    }

    IEnumerator CoUpdate()
    {
    
        if (canCount == false && doOnce == true)
        {
            yield return new WaitForSeconds(1);
            Time.timeScale = 0;
        }
        yield return null;
    }
}
