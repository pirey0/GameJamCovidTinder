using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timeText;
    [SerializeField] float duration = 60;

    public event System.Action OnTimerEnd;

    float endtime;
    bool running;

    void Start()
    {
        endtime = Time.time + duration;
        running = true;
    }

    void Update()
    {
        if (!running)
        {
            return;
        }

        float timeLeft = endtime - Time.time;

        timeText.text = Mathf.CeilToInt(timeLeft).ToString();

        if(timeLeft <= 0)
        {
            running = true;
            OnTimerEnd?.Invoke();
        }
    }


}
