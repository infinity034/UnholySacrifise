using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityUI : MonoBehaviour
{
    [SerializeField]
    private GameObject[] visibilityLevelGo;

    [SerializeField]
    private int currentLevel = 0;

    private void Start()
    {
        ModifyVisibilityLevel(currentLevel, true);
    }

    public void ModifyVisibilityLevel(int value, bool add)
    {
        if (add)
        {
            if (currentLevel >= 0 && currentLevel < visibilityLevelGo.Length - 1) 
            {
                currentLevel += value;
                if(currentLevel >= visibilityLevelGo.Length)
                {
                    currentLevel = visibilityLevelGo.Length - 1;
                }
            }
        }
        else
        {
            if (currentLevel > 0 && currentLevel <= visibilityLevelGo.Length - 1)
            {
                currentLevel += value;

                if (currentLevel < 0)
                {
                    currentLevel = 0;
                }
            }
        }

        foreach (GameObject go in visibilityLevelGo)
        {
            go.SetActive(false);
        }

        visibilityLevelGo[currentLevel].SetActive(true);
    }
}
