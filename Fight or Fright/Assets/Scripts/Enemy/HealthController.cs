
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float MaxHealthPoints = 3;
    public float currentHealth = 3;
    public static int ZombieUp = 0;
    public static int moneyPerKill;



    void Start()
    {
        MonstersUp.s_MonstersUp.OnMonstersUpgradeed += OnMonsterUpgraded;



        currentHealth = MaxHealthPoints;
    }
    public void SetHp(float Health)
    {
        MaxHealthPoints = Health;
        currentHealth = Health;
    }

    void Update()
    {

        if (currentHealth <= 0)
        {
            Debug.Log(moneyPerKill);
            Enemy.aliveEnemies--;
            Destroy(gameObject);
            Enemy.killEnemy++;
            moneyPerKill += 3;
            Cannon.currentProjectiles += 1;
        }

    }


    public void OnMonsterUpgraded()
    {
        MaxHealthPoints++;
        currentHealth++;

    }


}