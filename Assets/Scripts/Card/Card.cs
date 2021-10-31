using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Card : MonoBehaviour
{

    public int number;
    public TMP_Text text;
    //ClickActionに自身の情報も＜＞で伝える(引数をもつ）
    public UnityAction<Card>ClickAction;

    //役職

    

    public void Init(int number)
    {
        this.number = number;
        text.text = number.ToString();
    }
    public void OnClickThis()
    {
        Debug.Log("カードが押されたよ");
        //外部に解放されている変数のようなもの(依存しない)
        //playerのselectCardを実行したい
        ClickAction.Invoke(this);
    
    }
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
