using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int counter = 0;
    public string name =  "";

    [SerializeField] Text counterText;
    [SerializeField] Text nameText;

    public void Start(){
        Load();
    }

    public void IncrementCounter(){
        counter++;
    }

    public void SetName(string newName){
        name = newName;
    }

    public void Save(){
        PlayerPrefs.SetInt("counter", counter);
        PlayerPrefs.SetString("name", name);
    }

     public void Load(){
        counter = PlayerPrefs.GetInt("counter", 999);
        name = PlayerPrefs.GetString("name", "No Name");
    }

    public void Reset(){
        counter = 0;
        name = "";

        PlayerPrefs.DeleteAll();
    }

    private void OnGUI(){
        counterText.text = counter.ToString();
        nameText.text = name;
    }
}
