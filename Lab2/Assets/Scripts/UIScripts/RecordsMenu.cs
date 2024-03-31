using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;
using System.Xml.Linq;

public class RecordsMenu : MonoBehaviour
{
    private VisualElement recordsMenu;
    private List<string> records = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        recordsMenu = root.Q<VisualElement>("records-menu");
        recordsMenu.Q<Button>("play-btn").clicked += () => Play();
        recordsMenu.Q<Button>("exit-btn").clicked += () => Exit();
    }

    public void AddToRecords(string name)
    {
        records.Add(name);
    }

    public void ShowRecords()
    {
        recordsMenu.style.display = DisplayStyle.Flex;
    }

    public void Play()
    {
        recordsMenu.style.display = DisplayStyle.None;
        Time.timeScale = 1;
    }
    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
