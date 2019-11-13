using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SetDialogueTxt : MonoBehaviour
{
    public Text _txt;
    public GameObject continueBtn;
    public Image background;
    public Action<string[], bool> SetDialogue;
    public Action<bool> isActive;

    public float _typeSpeed = 0.15f;

    private string[] _sentences;
    private int index = 0;
    private bool _isTyping = false;
    private bool _isActive = false;
    private bool _skipTyping = false;
    private bool  _showContinueBtn = true;


    void Start()
    {
        background.enabled = false;
        continueBtn.SetActive(false);
        _txt.text = "";
        SetDialogue += StartText;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _skipTyping = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            NextText();
        }
    }

    private void StartText(string[] _texts, bool _hasContinueBtn)
    {
        background.enabled = true;
         _showContinueBtn = _hasContinueBtn;
        index = 0;
        _sentences = _texts;
        StartCoroutine(TypeText());
    }

    public void NextText()
    {
        continueBtn.SetActive(false);
        index++;
        if (index < _sentences.Length)
        {
            StartCoroutine(TypeText());
        } else
        {
            isActive(_isActive);
            _txt.text = "";

            background.enabled = false;
            _sentences = null;
        }
    }

    IEnumerator TypeText()
    {
        _isTyping = true;
        isActive(true);
        _txt.text = "";
        float speed = _typeSpeed;
        foreach (char letter in _sentences[index].ToCharArray())
        {
            _txt.text += letter;
            if (_skipTyping)            {
                speed = 0;
            }
            yield return new WaitForSeconds(speed);
        }
        _isTyping = false;
        _skipTyping = false;
        if ( _showContinueBtn)
        {
            continueBtn.SetActive(true);
        }
    }

    public void FinishDialogue()
    {
        _txt.text = "";
        background.enabled = false;
        continueBtn.SetActive(false);
    }
}