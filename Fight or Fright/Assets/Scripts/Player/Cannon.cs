using System.Collections;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform cannonBarrel;
    public static int maxProjectiles = 50;
    public static int currentProjectiles = 50;
    public int speedProjectiles = 25;

    public Animator animUI;
    public Animator shotGun;

    public GameObject Fighters;
    private bool lose = false;
    void Start()
    {
        currentProjectiles = maxProjectiles;

    }

    public void Fire()
    {
    
        
            Vector3 clickPosition = Input.mousePosition;
            clickPosition.z = 10f;

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);

            GameObject projectile = Instantiate(projectilePrefab, cannonBarrel.position, Quaternion.identity);

            Vector3 direction = (worldPosition - cannonBarrel.position).normalized;
            projectile.GetComponent<Rigidbody>().velocity = direction * speedProjectiles;
            Destroy(projectile, 3f);
        
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && currentProjectiles > 0)
        {
            shotGun.SetTrigger("Shot");
            Fire();
            currentProjectiles--;


        }
        if (currentProjectiles == 0 || Enemy.aliveEnemies >= 10)
        {
            if (!lose)
            {
                Refresh();

                lose = true;
            }


        }

    }
    public void Refresh()
    {


        animUI.SetInteger("Menu", 4);
        //Debug.Log("lose");
        Fighters.SetActive(false);
        GameObject[] collector = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject element in collector)
        {
            Destroy(element);
        }

    }

}