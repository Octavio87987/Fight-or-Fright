using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageForPlayer : MonoBehaviour
{
    public static int Damage = 1;
   

    public AudioClip hitSFX;
    public AudioSource _audioSource;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            var hc = other.GetComponent<HealthController>();
            hc.currentHealth -= Damage;
            Debug.Log(hc.currentHealth);
            _audioSource.PlayOneShot(hitSFX);
        }
        
    }

}