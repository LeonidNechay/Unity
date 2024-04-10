using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HeathPoints : MonoBehaviour
{
    [SerializeField]
    private int healthPoint = 3;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Obtacle") && gameObject.CompareTag("Player"))
        {
            healthPoint--;
            if(healthPoint == 0)
            {
                Debug.Log("GAME OVER");
                UnityEditor.EditorApplication.isPlaying = false;
            }
            else
            {
                Debug.Log(healthPoint.ToString() + "<3");
            }
        }
    }
}
