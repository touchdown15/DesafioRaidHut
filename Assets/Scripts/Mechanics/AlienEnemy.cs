using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienEnemy : MonoBehaviour
{
    public GameObject projectile;
    private float timeBtwShoot;
    public float startTimeBtwShoot;
    // Start is called before the first frame update
    void Start()
    {
        timeBtwShoot = startTimeBtwShoot;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwShoot <= 0){
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShoot = startTimeBtwShoot;

        }else{
            timeBtwShoot -= Time.deltaTime;
        }
    }
}
