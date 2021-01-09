using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject Projectile;
    public Transform ShootPos;
    public float timeToDestroy;
    public float timeBetweenSummon;
    public void Start()
    {
        StartCoroutine(SummonProjectile());
    }

    IEnumerator SummonProjectile()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenSummon);
            
            GameObject clone = Instantiate(Projectile, ShootPos.position, Quaternion.identity);
            if (clone.CompareTag("Rocket"))
            {
               clone.transform.rotation = Quaternion.Euler(0, 0, -90);
            }
            //Destroy(clone, timeToDestroy);
        }
      
    }
   
}
