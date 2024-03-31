using UnityEngine;

public class Obstacle : MonoBehaviour
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
        FindFirstObjectByType<Counter>().AddValue();
        Player.transform.position = SpawnPoint.transform.position;
    }
}
