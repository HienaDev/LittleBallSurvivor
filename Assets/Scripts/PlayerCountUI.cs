using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCountUI : MonoBehaviour
{

    private TMP_Text text;



    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }



    public void ChangeCounterUI(int number)
    {
        text.text = $"Players:\n{number}";
    }
}
