using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagCheckPoint : MonoBehaviour
{
    private GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.Find("SpawnPoint");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            spawnPoint.transform.position = this.gameObject.transform.position;
            Destroy(this.gameObject);
        }
    }

}
