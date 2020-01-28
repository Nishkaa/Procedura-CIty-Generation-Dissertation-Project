using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetMouseButton((0))){
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
