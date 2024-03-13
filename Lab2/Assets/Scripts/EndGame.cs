using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    private GameObject SpawnPoint;
    [SerializeField]
    private GameObject Player;
    private void Start()
    {
        SpawnPoint = GameObject.FindWithTag("Respawn");
        Player = GameObject.FindWithTag("Player");

    }
    private void OnTriggerEnter(Collider col)
    {   
        if (gameObject.tag == "Finish")
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Debug.Log("You win!");
        }
        else if(gameObject.tag == "Obtacle")
        {
            Player.transform.position = SpawnPoint.transform.position;
            Debug.Log("You lose");
        }
    }
}
