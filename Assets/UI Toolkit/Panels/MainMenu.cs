using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{

    private void Awake()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        root.Q<Button>("PlayBtn").clicked += PlayButtonOnClicked;
        root.Q<Button>("SettingsBtn").clicked += SettingsButtonOnClicked;
        root.Q<Button>("ExitBtn").clicked += ExitButtonOnClicked;
    }

    private void PlayButtonOnClicked()
    {
        SceneManager.LoadScene(1);
    }

    private void SettingsButtonOnClicked()
    {
        Debug.Log("he prsionado Settings para configurar el juego y que se vea lindo todo");
    }

    private void ExitButtonOnClicked()
    {
        Application.Quit();
        Debug.Log("he prsionado Quit para salir del juego y que se vea lindo todo");
    }
}
