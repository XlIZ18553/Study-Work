using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageGen : MonoBehaviour
{
    
    public GameObject[] Garbage;
    public GameObject[] Plastic;
    public GameObject[] Apple;
    int i = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        PlasticGen();
        AppleGen();
        RubbishGen();
     
    }

    private void AppleGen()
    {
        do
        {
            Instantiate(Apple[i], new Vector3(Apple[i].transform.position.x, Apple[i].transform.position.y, 0), Quaternion.identity);
            i++;
        } while (i < Apple.Length);
    }

    private void PlasticGen()
    {
        int i = 0;
        while (i < Plastic.Length)
        {
          Instantiate(Plastic[i], new Vector3(Plastic[i].transform.position.x, Plastic[i].transform.position.y, 0), Quaternion.identity);
          i++;
        }
    }

    private void RubbishGen()
    {
        for (int i = 0; i < Garbage.Length; i++)
        {
            Instantiate(Garbage[i], new Vector3(Garbage[i].transform.position.x, Garbage[i].transform.position.y, 0), Quaternion.identity);
        }
    }

}
