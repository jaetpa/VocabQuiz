using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput : MonoBehaviour
{
    [SerializeField]
    private string testWord;
    [SerializeField]
    private WordBuilder wordBuilder;
    // Start is called before the first frame update
    void Start()
    {
        SetTestWord();
    }

    [ContextMenu("Set Test Word")]
    private void SetTestWord()
    {
        wordBuilder.SetWord(testWord.ToUpper());
    }

}
