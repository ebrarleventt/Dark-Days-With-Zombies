using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Oyunbitti : MonoBehaviour
{
    public Text puan;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        puan.text = "Puan�n�z:" + PlayerPrefs.GetInt("puan");
    }

    // Update is called once per frame
    public void yenidenOyna()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
