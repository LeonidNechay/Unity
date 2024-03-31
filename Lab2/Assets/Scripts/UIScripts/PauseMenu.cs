using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class PauseMenu : MonoBehaviour
{
    private VisualElement pauseMenu;
    bool gamePause = false;
    private void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        pauseMenu = root.Q<VisualElement>("pause-menu");
        root.Q<Button>("resume-btn").clicked += () => Resume();
        root.Q<Button>("restart-btn").clicked += () => Restart();
        root.Q<Button>("exit-btn").clicked += () => Exit();

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!gamePause)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }
    
    public void Pause()
    {
        gamePause = true;
        pauseMenu.style.display = DisplayStyle.Flex;
        Time.timeScale = 0;
    }
    public void Resume()
    {
        gamePause = false;
        pauseMenu.style.display = DisplayStyle.None;
        Time.timeScale = 1;
    }
    public void Restart()
    {
        pauseMenu.style.display = DisplayStyle.None;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
