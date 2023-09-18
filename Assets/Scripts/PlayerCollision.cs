using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {

            other.gameObject.SetActive(false);
            _gameManager.IncrementCount();
        }
    }
}
