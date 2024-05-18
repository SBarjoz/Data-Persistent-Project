using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputName;
    // Start is called before the first frame update
    void Start()
    {
        inputName.text = DataManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        if(inputName.text != string.Empty )
        {
            SceneManager.LoadScene(1);
            DataManager.Instance.playerName = inputName.text;
            DataManager.Instance.SaveValue();
        }
    }
}