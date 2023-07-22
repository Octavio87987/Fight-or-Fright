using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstersUp : MonoBehaviour
{
    public static MonstersUp s_MonstersUp;
    public float increaseRate ;
    private float timer = 0f;
    public Action OnMonstersUpgradeed;

    public void Awake()
    {
        s_MonstersUp = this;
    }

    public void Update()
    {
        timer += Time.deltaTime;

        if (timer >= increaseRate)
        {
            
            OnMonstersUpgradeed?.Invoke();
            Debug.Log("Monsters has been Upgrade");
            timer = 0f;
        }
    }
}