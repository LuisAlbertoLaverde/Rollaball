using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _count;

    [SerializeField] private TextMeshProUGUI _countText;
    [SerializeField] private GameObject _winTextObject;


    // Start is called before the first frame update
    private void Start()
    {
        SetCountText();
        _winTextObject.SetActive(false);
    }

    private void SetCountText()
    {
        _countText.text = $"Count: {_count.ToString()}";
        if (_count >= 12)
        {
            _winTextObject.SetActive(true);
        }
    }
    public void IncrementCount()
    {
        _count++;
        SetCountText();
    }

}
