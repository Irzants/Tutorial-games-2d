using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] float timeComplete = 30f;
    [SerializeField] float timeShow = 10f;


    public bool loadNextQuestion;
    public float fillFraction;

    public bool isAnsweringQuestion;
    float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if(isAnsweringQuestion)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeComplete;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeShow;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeShow;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeComplete;
                loadNextQuestion = true;
            }
        }
    }

}
