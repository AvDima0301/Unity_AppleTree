using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button btnNewGame;
    // Start is called before the first frame update
    void Start()
    {
        btnNewGame = GameObject.Find("NewGame").GetComponent<Button>();
        btnNewGame.onClick.AddListener(delegate { OnClick(); } );
    }

    void OnClick()
    {
        SceneManager.LoadScene("_Scene0_");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
