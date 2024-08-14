using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] int countToStart = 8;
    [SerializeField] GameObject mainPlayer;


    private void Awake()
    {
        mainPlayer.SetActive(true);
    }
    void Start()
    {
        mainPlayer.SetActive(false);
        StartCoroutine(StartGame(countToStart));
    }

    // Update is called once per frame
    IEnumerator StartGame(int i)
    {
        yield return new WaitForSeconds(i);
        mainPlayer.SetActive(true);
    }
}
