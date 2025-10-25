using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevelPopup : MonoBehaviour
{
    [System.Serializable]
    public struct CategoryName
    {
        public string name;
        public Sprite sprite;
    }

    public GameData currentGameData;
    public List<CategoryName> categoryNames;
    public GameObject winPopup;
    public TMP_Text categoryName;

    void Start()
    {
        winPopup.SetActive(false);

        GameEvents.OnUnlockNextCategory += OnUnlockNextCategory;
    }

    private void OnDisable()
    {
        GameEvents.OnUnlockNextCategory -= OnUnlockNextCategory;
    }

    private void OnUnlockNextCategory()
    {
        bool captureNext = false;

        foreach (var writing in categoryNames)
        {
            if (captureNext)
            {
                categoryName.text = writing.name;
                captureNext = false;
                break;
            }
            if (writing.name == currentGameData.selectedCategoryName)
            {
                captureNext = true;
            }
        }
        winPopup.SetActive(true);
    }
}   
