using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    private VisualElement mainMenu;
    private string Name;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        mainMenu = root.Q<VisualElement>("main-menu");
        root.Q<Button>("play-btn").clicked += () => Play();
        root.Q<Button>("records-btn").clicked += () => Records();
        root.Q<Button>("exit-btn").clicked += () => Exit();
    }

    public void Play()
    {
        Name = GetComponent<UIDocument>().rootVisualElement.Q<TextField>("name-field").value;
        FindObjectOfType<EndGame>().SetName(Name);
        mainMenu.style.display = DisplayStyle.None;
        Time.timeScale = 1;
    }
    public void Records()
    {
        mainMenu.style.display = DisplayStyle.None;
        FindObjectOfType<RecordsMenu>().ShowRecords();
    }
    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
