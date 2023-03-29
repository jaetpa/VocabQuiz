using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordBuilder : MonoBehaviour
{
    [SerializeField]
    private Letter letterPrefab;
    [SerializeField]
    private HorizontalLayoutGroup layout;

    string _word;
    public void SetWord(string word)
    {
        ClearCurrentWord();
        _word = word;
        BuildWord(_word);
    }

    private void BuildWord(string word)
    {
        foreach (var letterCharacter in word)
        {
            var letter = Instantiate(letterPrefab, layout.transform);
            letter.SetLetter(letterCharacter);
        }
    }

    private void ClearCurrentWord()
    {
        _word = null;
        foreach (Transform child in layout.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
