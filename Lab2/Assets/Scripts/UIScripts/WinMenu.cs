using UnityEngine;
using UnityEngine.UIElements;

public class WinMenu : MonoBehaviour
{
    private VisualElement winMenu;
    // Start is called before the first frame update
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        winMenu = root.Q<VisualElement>("win-menu");
        root.Q<Button>("exit-btn").clicked += () => Exit();
        root.Q<Button>("records-btn").clicked += () => Records();
    }
    public void ShowMenu()
    {
        winMenu.style.display = DisplayStyle.Flex;
    }
    public void Records() {
        winMenu.style.display = DisplayStyle.None;
        FindObjectOfType<RecordsMenu>().ShowRecords();
    }
    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
