using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DayClock : MonoBehaviour
{
    [SerializeField]
    private Image imageFill;

    [SerializeField]
    private TextMeshProUGUI dayClockTxt;

    [SerializeField]
    private int day = 1, maxDay = 4;

    [SerializeField]
    private float dayTime;

    public float FillAmount { get { return imageFill.fillAmount; } }

    private void Start()
    {
        SetDayClock();
    }

    private void SetDayClock()
    {
        dayClockTxt.text = "Day " + day;
        StartCoroutine(ShowDayFill());
    }

    private IEnumerator ShowDayFill()
    {
        float count = 0;
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
