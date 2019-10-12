using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SetDialogueTxt : MonoBehaviour
{
    public Action<string[]> displayText;
    public Action abortDialogue;
    private string[] _sentences;
    //private List<string> _texts = new List<string>();

    private float _typeSpeed = 0.15f;
    private int index = 0;
    private bool _isTyping = false;
    private bool skipTyping = false;

    public GameObject continueBtn;
    public GameObject background;

    private Text _txt;

    private DialogueTrigger _dialogueTrigger;

    void Start()
    {
        background.SetActive(false);
        continueBtn.SetActive(false);
        displayText += StartText;
        abortDialogue += QuitDialogue;
        _txt = GetComponent<Text>();
        _dialogueTrigger = FindObjectOfType<DialogueTrigger>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            skipTyping = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            NextText();
        }
    }

    private void StartText(string[] _texts)
    {
        index = 0;
        _sentences = _texts;
        background.SetActive(true);
        StartCoroutine(TypeText());
    }

    public void NextText()
    {

        continueBtn.SetActive(false);
        index++;
        Debug.Log(index + " " + _sentences.Length);
        if (index < _sentences.Length)
        {
            StartCoroutine(TypeText());
        } else
        {
            _txt.text = "";
            
            if(_dialogueTrigger.finishDialogue != null)
            {
                _dialogueTrigger.finishDialogue();
            }

            background.SetActive(false);
            _sentences = null;
        }
    }

    IEnumerator TypeText()
    {
        _isTyping = true;
        _txt.text = "";
        float speed = _typeSpeed;
        foreach (char letter in _sentences[index].ToCharArray())
        {
            _txt.text += letter;
            if (skipTyping)
            {
                speed = 0;
            }
            yield return new WaitForSeconds(speed);
        }
        _isTyping = false;
        skipTyping = false;
        continueBtn.SetActive(true);
    }

    public void QuitDialogue()
    {
        _txt.text = "";
        background.SetActive(false);
        _sentences = null;
    }

}
