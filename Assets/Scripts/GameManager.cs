using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _count;
    public LevelChange levelChange;

    [SerializeField] private TextMeshProUGUI _countText;
    [SerializeField] private GameObject _winTextObject;


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

            if (levelChange != null)
            {
                levelChange.ChangeToNextScene();
            }
        }
    }
    public void IncrementCount()
    {
        _count++;
        SetCountText();
    }
    public void SetLevelChangeReference(LevelChange newLevelChange)
    {
        this.levelChange = newLevelChange;
    }   

}
