using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;
    public Text theText;


    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    public CharacterController2D player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharacterController2D>();
        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        if(endAtLine == 0)
        {
            endAtLine = textLines.Length;
        }
    }
     void Update()
    {
        theText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
        }

        if(currentLine > endAtLine)
        {
            textBox.SetActive(false);
        }
    }
}
