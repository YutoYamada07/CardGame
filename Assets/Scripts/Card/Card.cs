using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Card : MonoBehaviour
{

    public int number;
    public TMP_Text text;
    //ClickAction�Ɏ��g�̏��������œ`����(���������j
    public UnityAction<Card>ClickAction;

    //��E

    

    public void Init(int number)
    {
        this.number = number;
        text.text = number.ToString();
    }
    public void OnClickThis()
    {
        Debug.Log("�J�[�h�������ꂽ��");
        //�O���ɉ������Ă���ϐ��̂悤�Ȃ���(�ˑ����Ȃ�)
        //player��selectCard�����s������
        ClickAction.Invoke(this);
    
    }
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
