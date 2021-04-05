using System;
using System.IO;
using UnityEngine;
using TMPro;

public class FileSaver : MonoBehaviour
{
    [SerializeField] TextMeshPro description;
    void Start()
    {
        description.text = Application.persistentDataPath;
        Debug.Log(Application.persistentDataPath);
        SaveFile();
    }

    void Update()
    {
        
    }

    public void SaveFile()
    {
        var path = Application.persistentDataPath + "\\my_file.txt";
        using (StreamWriter sw = File.AppendText(path))
        {
            string s = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            sw.WriteLine(s);
            Debug.Log(s);
            description.text = path + "\n Added " + s;
        }
    }
}
