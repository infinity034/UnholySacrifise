using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DayClock : MonoBehaviour
{
    public static DayClock Instance;

    [SerializeField]
    private Image imageFill;

    [SerializeField]
    private TextMeshProUGUI dayClockTxt;

    [SerializeField]
    private int day = 1, maxDay = 4;

    [SerializeField]
    private float dayTime;

    private int count = 0;

    public float FillAmount { get { return imageFill.fillAmount; } }
    public float DayTime { get { return dayTime; } }
    public int CurrentDay { get { return day; } }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SetDayClock();
    }

    private void SetDayClock()
    {
        dayClockTxt.text = "Day " + day;
        StartCoroutine(ShowDayFill());
    }

    public void SkipADay()
    {
        if (day < maxDay)
        {
            count = 0;
            day++;
            dayClockTxt.text = "Day " + day;
        }
    }

    private IEnumerator ShowDayFill()
    {
        count = 0;
        do
        {
            imageFill.fillAmount = 1f - (count / dayTime);
            count++;
            if(count > dayTime)
            {
                count = 0;
                day++;
                dayClockTxt.text = "Day " + day;
                imageFill.fillAmount = 1f;
            }
            yield return new WaitForSeconds(1f);
        }while (day < maxDay);
    }
}
