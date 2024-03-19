using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (gameObject.tag == "Finish")
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Debug.Log("You win!");
        }
    }
}
