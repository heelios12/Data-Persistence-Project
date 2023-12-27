using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputName : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI maximumScorePlayerNameText;

    // Start is called before the first frame update
    void Start()
    {
        SaveData.Load();

        maximumScorePlayerNameText.text = $"Best Score: {MainManager.maxiumumPlayerName} : {MainManager.maximumPlayerScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetName(string name)
    {
        MainManager.playerName = name;
    }

    public void InitGame()
    {
        SceneManager.LoadScene("main");
    }

    public void Exit()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit(); // original code to quit Unity player
    #endif
    }
}
