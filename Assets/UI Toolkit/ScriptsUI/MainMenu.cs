using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    public LevelChange levelChange;

    private void Awake()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        root.Q<Button>("PlayBtn").clicked += () => PlayButtonOnClicked();
        root.Q<Button>("SettingsBtn").clicked += () => SettingsButtonOnClicked();
        root.Q<Button>("ExitBtn").clicked += () => ExitButtonOnClicked();
    }

    private void PlayButtonOnClicked()
    {
        levelChange.ChangeToNextScene();    
    }

    private void SettingsButtonOnClicked()
    {
        Debug.Log("he prsionado Settings para configurar el juego");
    }

    private void ExitButtonOnClicked()
    {
        Application.Quit();
        Debug.Log("he presionado Quit para salir del juego");
    }
}
