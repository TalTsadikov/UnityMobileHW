using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class SaveText : MonoBehaviour
{
    public TMP_InputField input;
    public TextMeshProUGUI textToLoad;
    private string savedString;

    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/file.txt"))
        {
            File.Delete(Application.persistentDataPath + "/file.txt");
        }
    }

    void Update()
    {
        if (File.Exists(Application.persistentDataPath + "/file.txt"))
        {
            savedString = File.ReadAllText(Application.persistentDataPath + "/file.txt");
        }
    }

    public void SaveString()
    {
        string stringToSave = input.text;

        File.AppendAllText(Application.persistentDataPath + "/file.txt", stringToSave);
    }

    public void LoadString()
    {
        textToLoad.text = savedString;
    }
}
