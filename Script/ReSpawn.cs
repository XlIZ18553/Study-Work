using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public GameObject[] respawns;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player") ;
        {
            Destroy(GameObject.FindWithTag("Player"));
            Instantiate(respawns[0], respawns[0].transform.position, respawns[0].transform.rotation); 
        }
    }
}
