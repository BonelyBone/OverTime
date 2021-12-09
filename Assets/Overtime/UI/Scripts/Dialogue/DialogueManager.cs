using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Queue<string> sentences;
    public GameObject UIDialouge;
    public Text nameText;
    public Text DialougeText;
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialouge(Dialouge dialogue)
    {
        Debug.Log("Starting Dialouge with " + dialogue.name);
        nameText.text = dialogue.name;

        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
       if (sentences.Count == 0)
       {
            EndDialouge();
            return;
       }

        string sentence = sentences.Dequeue();
        DialougeText.text = sentence;
        Debug.Log(sentence);
    }
        void EndDialouge()
        {
            UIDialouge.gameObject.SetActive(false);
            Debug.Log("End of Dialouge");
        }
    
}
