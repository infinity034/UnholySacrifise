using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImpactBar : MonoBehaviour
{
    public static ImpactBar Instance;

    [SerializeField]
    private Image goodFill, badFill;

    [SerializeField]
    private float goodAmount, badAmount, maxAmount;

    private void Awake()
    {
        Instance = this;
    }

    public void SetImpactBar(float value, bool good)
    {
        if (good)
        {
            if (value < badAmount)
            {
                badAmount -= value;
                StartCoroutine(FillOverTime(badFill, badAmount, false));
            }
            else if(value > badAmount) 
            {
                badAmount = 0;
                StartCoroutine(FillOverTime(badFill, badAmount, false));
                goodAmount += value - badAmount;
                StartCoroutine(FillOverTime(goodFill, goodAmount, true));
            }
            else
            {
                badAmount = 0;
                StartCoroutine(FillOverTime(badFill, badAmount, false));
                goodAmount = 0;
                StartCoroutine(FillOverTime(goodFill, goodAmount, true));
            }

            if (goodAmount >= maxAmount)
            {
                goodAmount = maxAmount;
                goodFill.fillAmount = 1;
                badFill.fillAmount = 0;
            }
        }
        else
        {
            if (value < goodAmount)
            {
                goodAmount -= value;
                StartCoroutine(FillOverTime(goodFill, goodAmount, false));
            }
            else if (value > goodAmount)
            {
                goodAmount = 0;
                StartCoroutine(FillOverTime(goodFill, goodAmount, false));
                badAmount += value - goodAmount;
                StartCoroutine(FillOverTime(badFill, badAmount, true));
            }
            else
            {
                goodAmount = 0;
                StartCoroutine(FillOverTime(goodFill, goodAmount, false));
                badAmount = 0;
                StartCoroutine(FillOverTime(badFill, badAmount, true));
            }

            if (badAmount >= maxAmount)
            {
                badAmount = maxAmount;
                goodFill.fillAmount = 0;
                badFill.fillAmount = 1;
            }
        }
    }

    public void ResetToZero()
    {
        goodAmount = 0;
        StartCoroutine(FillOverTime(goodFill, goodAmount, false));
        badAmount = 0;
        StartCoroutine(FillOverTime(badFill, badAmount, false));
    }

    private IEnumerator FillOverTime(Image fill, float amount, bool add)
    {
        if (add)
        {
            do
            {
                fill.fillAmount += 0.01f;
                yield return new WaitForSeconds(0.1f);
            } while (fill.fillAmount <= (amount / maxAmount));
            fill.fillAmount = (amount / maxAmount);
        }
        else
        {
            do
            {
                fill.fillAmount -= 0.01f;
                yield return new WaitForSeconds(0.1f);
            } while (fill.fillAmount >= (amount / maxAmount));
            fill.fillAmount = (amount / maxAmount);
        }
    }

   //Façons alternative.
    /*
    public int action;
    public int score;

    [SerializeField] GameObject sword;

    public void SubstractPoints()
    {
        score = score-action;
        DisplayPoints();
    }

    public void AddPoints()
    {
        score= score+action;
        DisplayPoints();
    }

    public void ResetPoints()
    {
        score = 0;
        DisplayPoints();
    }
    
    void DisplayPoints()
    {
        sword.transform.localPosition = new Vector3(0, action, 0);
    }*/























}
