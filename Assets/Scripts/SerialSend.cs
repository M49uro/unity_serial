using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerialSend : MonoBehaviour
{
    public CreateMessage _createM;
    

    //SerialHandler.c�̃N���X
    public SerialHandler serialHandler;
    int i = 0;

    void FixedUpdate() //������0.001�b���ƂɎ��s�����
    {
        i = i + 1;   //i�����Z���Ă�����1�b���Ƃ�"1"�̃V���A�����M�����s
        if (i > 9) //
        {
            serialHandler.Write(_createM._sData + "\n");
            i = 0;
        }
    }
}
