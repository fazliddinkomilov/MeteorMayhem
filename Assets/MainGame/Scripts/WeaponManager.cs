using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject[] RealGuns;
    [SerializeField] GameObject[] gunIndex;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gunIndex[0].active == true)
        {
            RealGuns[0].SetActive(true);
        }
    }
}
