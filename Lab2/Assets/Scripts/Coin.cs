using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        gameObject.SetActive(false);
        FindFirstObjectByType<Counter>().AddValue();
    }
}
