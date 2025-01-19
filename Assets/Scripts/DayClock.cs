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
    private float[] fillAmount = { 1f, 0.75f, 0.5f, 0.25f, 0f };

    [SerializeField]
    private int day = 1, dayQuarter = 0;

    private void Start()
    {
        SetDayClock(day, dayQuarter);
    }

    private void SetDayClock(int day, int dayQuarter)
    {
        SetFill(dayQuarter);
        dayClockTxt.text = "Day " + day;
    }

    private void SetFill(int dayQuarter)
    {
        StartCoroutine(ShowDayFill(fillAmount[dayQuarter]));
    }

    private IEnumerator ShowDayFill(float goTo)
    {
        do
        {
            imageFill.fillAmount -= 0.001f;
            yield return new WaitForSeconds(0.1f);
        }while (imageFill.fillAmount >= fillAmount[dayQuarter]);

        imageFill.fillAmount = goTo;
    }
}
