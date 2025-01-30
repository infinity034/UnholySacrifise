using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImpactBar : MonoBehaviour
{
    public static ImpactBar Instance;
    
    [SerializeField]
    private Slider goodFill, badFill;

    private float badAmount, maxAmount, points;

    private void Awake()
    {
        Instance = this;
    }

    public void ActionPoints(float value, bool good)
    {
        if(good== true){
            points=points+value;
        }
        else if ( good==false){
            points=points-value;
        }
       SetPoints();
    }
    public void SetPoints()
    {
        Debug.Log(points);
        if(points>0){
            badAmount=0;
            goodFill.value=points;
        }
        else if( points<0){
            badAmount=points*-1;
            badFill.value=badAmount;
        }
        else{
            badAmount=0;
            points=0;
            goodFill.value=points;
            badFill.value=points;
        }
       
    }
  

    public void ResetToZero()
    {
        points=0;
        badAmount =0;
       goodFill.value=0;
       badFill.value=0;
    }
    public void TestPlus(){
        ActionPoints(10,true);
    }
    public void TestMoins(){
        ActionPoints(5,false);
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


/* if (good)
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
    StartCoroutine(FillOverTime(goodFill, goodAmount, false))
     StartCoroutine(FillOverTime(badFill, badAmount, false));
    */




















}
