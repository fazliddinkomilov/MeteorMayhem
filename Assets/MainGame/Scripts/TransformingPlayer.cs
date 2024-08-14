using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformingPlayer : MonoBehaviour
{
    [SerializeField] Transform MainPlayer;
    [SerializeField] GameObject RemotePlayer;
    [SerializeField] bl_FirstPersonController CON;
    void Start()
    {
        RemotePlayer.SetActive(true);
                CON.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
  /*      transform.position = MainPlayer.position;*/
    }
}
