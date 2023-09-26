using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    [SerializeField] private float transitionTime = 1f;
    private Animator _transitionAnimator;

    private void Start()
    {
        _transitionAnimator = GetComponentInChildren<Animator>();
    }
    public void ChangeToNextScene()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadScene(currentLevel + 1);
        StartCoroutine(SceneLoad(currentLevel + 1));
    }

    public IEnumerator SceneLoad(int sceneIndex)
    {
        //disparar el trigger para reproducir la animacion FadeIn
        _transitionAnimator.SetTrigger("StartTransition ");
        //esperar un segundo
        yield return new WaitForSeconds(transitionTime);
        //cargar la escena
        SceneManager.LoadScene(sceneIndex);
    }
}
