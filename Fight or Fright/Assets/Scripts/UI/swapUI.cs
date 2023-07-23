using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swapUI : MonoBehaviour
{

    public int UI_Num;
    public Animator animUI;
    public GameObject Spawner;
    void Awake()
    {

    }
    public void SwapStart()
    {
        if (UI_Num == 1)
        {

            animUI.SetInteger("Menu", 1);

            Spawner.SetActive(true);
            Cannon.lose = false;

        }
        if (UI_Num == 2)
        {
            animUI.SetInteger("Menu", 2);
        }
        if (UI_Num == 3)
        {
            animUI.SetInteger("Menu", 3);
        }
        if (UI_Num == 5)
        {
        }
        if (UI_Num == 0)
        {
            Enemy.againSpawn = true;
            animUI.SetInteger("Menu", 0);
        }
    }
        public void ExitGame()
        {
            Application.Quit();
        Debug.Log("ex");

        }
    
    public void Reset()
    {
        Enemy.killEnemy = 0;
        HealthController.moneyPerKill = 0;
        Cannon.currentProjectiles = 50;
        Enemy.aliveEnemies = 0;
    }



}
