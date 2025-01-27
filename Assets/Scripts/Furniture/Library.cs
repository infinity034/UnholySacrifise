using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Library : MovableFurniture
{
    public static Library Instance;

    private void Awake()
    {
        Instance = this;
    }
}
