using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class MessageText : MonoBehaviour
{
    public CreateMessage _createM;

    public Text TextMessage;
    //public Text TextTest;
    //private int Ttest;

    // Start is called before the first frame update
    void Start()
    {
        //Ttest = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //TextTest.text = string.Format("{0:00000} test", Ttest);
        TextMessage.text = string.Format("{0}", _createM._message);
    }
}
