using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour
{
    [SerializeField]
    private char letter;
    [SerializeField]
    private Button button;
    [SerializeField]
    private TMP_Text text;


    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(HandleButtonClicked);
    }

    private void HandleButtonClicked()
    {
        throw new NotImplementedException();
    }

    public void SetLetter(char letter)
    {
        this.letter = letter;
        if (letter != default(char))
        {
            text.text = letter.ToString();
            gameObject.name += " - " + letter;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
