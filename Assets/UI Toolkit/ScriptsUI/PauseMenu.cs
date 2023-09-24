using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PauseMenu : MonoBehaviour
{
    private VisualElement pauseMenu;
    bool gamePaused = false;

    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        pauseMenu = root.Q<VisualElement>("pause-menu");
        root.Q<Button>("resume-btn").clicked += () => ResumeGame();
        root.Q<Button>("back-to-main-menu-btn").clicked += () => BackToMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    private void PauseGame()
    {
        gamePaused = true;
        pauseMenu.style.display = DisplayStyle.Flex;
    }

    private void ResumeGame()
    {
        gamePaused=false;
        pauseMenu.style.display = DisplayStyle.None;

    }

    private void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
