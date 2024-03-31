using Palmmedia.ReportGenerator.Core;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EndGame : MonoBehaviour
{
    private string PlayerName;

    void OnTriggerEnter(Collider col)
    {
        Time.timeScale = 0;
        FindObjectOfType<RecordsMenu>().AddToRecords(PlayerName);
        FindObjectOfType<WinMenu>().ShowMenu();
    }
    public void SetName(string name)
    {
        PlayerName = name;
    }

}
