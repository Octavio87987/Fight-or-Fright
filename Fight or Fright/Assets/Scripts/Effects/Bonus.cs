using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public bool avaliabelKill = false;
    public int priceKilll;
    public int priceFreez;
    public int priceCannonUp;
    public int priceAmmoUp;


    //private float timer = 0f;
    //public float spawnDelay = 0f;
    private float freezeTime = 5f;
    public static bool isFreeze = false;
    public GameObject FreezObj;
    //private bool isFrozen = false;



    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.K))
        {
            KillAllEnemy();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Freeze();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            CannonUp();
        }if (Input.GetKeyDown(KeyCode.A))
        {
            AmmoUp();
        }
    }



    public void KillAllEnemy()
    {
        if (HealthController.moneyPerKill >= priceKilll)
        {

            GameObject[] anigilate = GameObject.FindGameObjectsWithTag("Enemy");

            foreach (GameObject element in anigilate)
            {
                Destroy(element);
            }
            HealthController.moneyPerKill -= priceKilll;
            Debug.Log("kill");
        }



    }

    public void Freeze()
    {

        if (HealthController.moneyPerKill >= priceFreez)
        {



            FreezObj.SetActive(false);
            isFreeze = true;
            Invoke("UnFreeze", freezeTime);

            Debug.Log("FREEZE");
            HealthController.moneyPerKill -= priceFreez;

        }

    }

    public void UnFreeze()
    {

        Enemy.againSpawn = true;
        isFreeze = false;

        FreezObj.SetActive(true);
        Debug.Log("UNFREEZE");


    }

    public void CannonUp()
    {
        if (HealthController.moneyPerKill >= priceCannonUp)
        {
            DamageForPlayer.Damage ++;
            Debug.Log("UP");
            HealthController.moneyPerKill -= priceCannonUp;
        }


    } public void AmmoUp()
    {
        if (HealthController.moneyPerKill >= priceAmmoUp)
        {
            Cannon.currentProjectiles += 15 ;
            Debug.Log("UP");
            HealthController.moneyPerKill -= priceAmmoUp;
        }


    }
}
