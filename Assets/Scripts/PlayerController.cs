using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 0;
    [SerializeField] private TextMeshProUGUI _countText;
    [SerializeField] private GameObject _winTextObject;

    private Rigidbody _rb;
    private int _count;
    private float _movementX;
    private float _movementY;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        _count = 0;
        SetCountText();
        _winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        _movementX = movementVector.x;
        _movementY = movementVector.y;
    }

    private void SetCountText()
    {
        _countText.text = $"Count: {_count.ToString()}";
        if (_count >= 12)
        {
            _winTextObject.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(_movementX, 0.0f, _movementY);

        _rb.AddForce(movement * _speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            _count++;

            SetCountText();
        }
    }
}
