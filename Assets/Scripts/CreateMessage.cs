using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class CreateMessage : MonoBehaviour
{
    private GameInputs _gameInputs;
    public string _message;
    public string _sData;

    public int _Ci;
    public int _Cr;
    public int _Sq;
    public int _Tr;
    public int _Up;
    public int _Do;
    public int _Ri;
    public int _Le;
    public int _R1;
    public int _R2;
    public int _R3;
    public int _L1;
    public int _L2;
    public int _L3;
    public int _Op;
    public int _Sh;

    public Vector2 _LeftInputValue;
    public Vector2 _RightInputValue;


    // Start is called before the first frame update
    private void Awake()
    {
        _gameInputs = new GameInputs();

        _gameInputs.Action.Circle.performed += OnCircleStart;
        _gameInputs.Action.Circle.canceled += OnCircleEnd;
        _gameInputs.Action.Cross.performed += OnCrossStart;
        _gameInputs.Action.Cross.canceled += OnCrossEnd;
        _gameInputs.Action.Square.performed += OnSquareStart;
        _gameInputs.Action.Square.canceled += OnSquareEnd;
        _gameInputs.Action.Triangle.performed += OnTriangleStart;
        _gameInputs.Action.Triangle.canceled += OnTriangleEnd;

        _gameInputs.Action.Up.performed += OnUpStart;
        _gameInputs.Action.Up.canceled += OnUpEnd;
        _gameInputs.Action.Down.performed += OnDownStart;
        _gameInputs.Action.Down.canceled += OnDownEnd;
        _gameInputs.Action.Right.performed += OnRightStart;
        _gameInputs.Action.Right.canceled += OnRightEnd;
        _gameInputs.Action.Left.performed += OnLeftStart;
        _gameInputs.Action.Left.canceled += OnLeftEnd;

        _gameInputs.Action.R1.performed += OnR1Start;
        _gameInputs.Action.R1.canceled += OnR1End;
        _gameInputs.Action.R2.performed += OnR2Start;
        _gameInputs.Action.R2.canceled += OnR2End;
        _gameInputs.Action.R3.performed += OnR3Start;
        _gameInputs.Action.R3.canceled += OnR3End;
        _gameInputs.Action.L1.performed += OnL1Start;
        _gameInputs.Action.L1.canceled += OnL1End;
        _gameInputs.Action.L2.performed += OnL2Start;
        _gameInputs.Action.L2.canceled += OnL2End;
        _gameInputs.Action.L3.performed += OnL3Start;
        _gameInputs.Action.L3.canceled += OnL3End;

        _gameInputs.Action.Options.performed += OnOptionStart;
        _gameInputs.Action.Options.canceled += OnOptionEnd;
        _gameInputs.Action.Share.performed += OnShareStart;
        _gameInputs.Action.Share.canceled += OnShareEnd;

        _gameInputs.Action.RightStick.started += OnRight;
        _gameInputs.Action.RightStick.performed += OnRight;
        _gameInputs.Action.RightStick.canceled += OnRight;
        _gameInputs.Action.LeftStick.started += OnLeft;
        _gameInputs.Action.LeftStick.performed += OnLeft;
        _gameInputs.Action.LeftStick.canceled += OnLeft;

        _gameInputs.Enable();
    }

    // Start is called before the first frame update
    void Start()
    {
        _Ci = 0;
        _Cr = 0;
        _Sq = 0;
        _Tr = 0;
        _Up = 0;
        _Do = 0;
        _Ri = 0;
        _Le = 0;
        _R1 = 0;
        _R2 = 0;
        _R3 = 0;
        _L1 = 0;
        _L2 = 0;
        _L3 = 0;
        _Op = 0;
        _Sh = 0;

        _RightInputValue = new Vector2(0, 0);
        _LeftInputValue = new Vector2(0, 0);

        _message = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
    }

    private void OnDestroy()
    {
        _gameInputs?.Dispose();
    }

    private void OnCircleStart(InputAction.CallbackContext context)
    {
        _Ci = 1;
    }
    private void OnCircleEnd(InputAction.CallbackContext context)
    {
        _Ci = 0;
    }
    private void OnCrossStart(InputAction.CallbackContext context)
    {
        _Cr = 1;
    }
    private void OnCrossEnd(InputAction.CallbackContext context)
    {
        _Cr = 0;
    }
    private void OnSquareStart(InputAction.CallbackContext context)
    {
        _Sq = 1;
    }
    private void OnSquareEnd(InputAction.CallbackContext context)
    {
        _Sq = 0;
    }
    private void OnTriangleStart(InputAction.CallbackContext context)
    {
        _Tr = 1;
    }
    private void OnTriangleEnd(InputAction.CallbackContext context)
    {
        _Tr = 0;
    }
    private void OnUpStart(InputAction.CallbackContext context)
    {
        _Up = 1;
    }
    private void OnUpEnd(InputAction.CallbackContext context)
    {
        _Up = 0;
    }
    private void OnDownStart(InputAction.CallbackContext context)
    {
        _Do = 1;
    }
    private void OnDownEnd(InputAction.CallbackContext context)
    {
        _Do = 0;
    }
    private void OnRightStart(InputAction.CallbackContext context)
    {
        _Ri = 1;
    }
    private void OnRightEnd(InputAction.CallbackContext context)
    {
        _Ri = 0;
    }
    private void OnLeftStart(InputAction.CallbackContext context)
    {
        _Le = 1;
    }
    private void OnLeftEnd(InputAction.CallbackContext context)
    {
        _Le = 0;
    }
    private void OnR1Start(InputAction.CallbackContext context)
    {
        _R1 = 1;
    }
    private void OnR1End(InputAction.CallbackContext context)
    {
        _R1 = 0;
    }
    private void OnR2Start(InputAction.CallbackContext context)
    {
        _R2 = 1;
    }
    private void OnR2End(InputAction.CallbackContext context)
    {
        _R2 = 0;
    }
    private void OnR3Start(InputAction.CallbackContext context)
    {
        _R3 = 1;
    }
    private void OnR3End(InputAction.CallbackContext context)
    {
        _R3 = 0;
    }
    private void OnL1Start(InputAction.CallbackContext context)
    {
        _L1 = 1;
    }
    private void OnL1End(InputAction.CallbackContext context)
    {
        _L1 = 0;
    }
    private void OnL2Start(InputAction.CallbackContext context)
    {
        _L2 = 1;
    }
    private void OnL2End(InputAction.CallbackContext context)
    {
        _L2 = 0;
    }
    private void OnL3Start(InputAction.CallbackContext context)
    {
        _L3 = 1;
    }
    private void OnL3End(InputAction.CallbackContext context)
    {
        _L3 = 0;
    }
    private void OnOptionStart(InputAction.CallbackContext context)
    {
        _Op = 1;
    }
    private void OnOptionEnd(InputAction.CallbackContext context)
    {
        _Op = 0;
    }
    private void OnShareStart(InputAction.CallbackContext context)
    {
        _Sh = 1;
    }
    private void OnShareEnd(InputAction.CallbackContext context)
    {
        _Sh = 0;
    }
    private void OnRight(InputAction.CallbackContext context)
    {
        _RightInputValue = context.ReadValue<Vector2>()*100;
    }
    private void OnLeft(InputAction.CallbackContext context)
    {
        _LeftInputValue = context.ReadValue<Vector2>()*100;
    }


    static string ConvertString(string input)
    // 入力文字列を変換するメソッド。主な処理はここに記述されます。
    {
        int[] values = input.Split(',').Select(int.Parse).ToArray();
        // 入力文字列をカンマで分割し、各要素を整数型に変換して配列に格納します。

        string firstPart = string.Concat(values.Take(4).Select(v => ConvertToTwoDigitHex(v)));
        // 配列の最初の4つの値を2桁の16進数形式に変換し、それらを連結します。

        string binaryString = string.Concat(values.Skip(4).Take(17));
        // 配列の5番目以降17個の値を取得して2進数文字列として連結します。

        string secondPart = ConvertToSixDigitHex(binaryString);
        // 2進数文字列を6桁の16進数に変換します。

        return firstPart + secondPart;
        // 最初の部分と後半の部分を結合し、1つの文字列として返します。
    }

    static string ConvertToTwoDigitHex(int value)
    // 整数値を2桁の16進数形式に変換するメソッドです。
    {
        int shiftedValue = value + 100;
        // 値を-100から100の範囲から0から200の範囲にシフトします。

        return shiftedValue.ToString("X2");
        // シフトした値を2桁の16進数文字列に変換して返します。
    }

    static string ConvertToSixDigitHex(string binaryString)
    // 2進数文字列を6桁の16進数に変換するメソッドです。
    {
        int decimalValue = Convert.ToInt32(binaryString, 2);
        // 2進数文字列を10進数の整数に変換します。

        return decimalValue.ToString("X4");
        // 10進数の値を6桁の16進数文字列に変換して返します。
    }

    private string Encode(string _origin_message)
    {
        string _encode_message = "";

        _encode_message = ConvertString(_origin_message);

        return _encode_message;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _message = _RightInputValue.x.ToString("00") + "," + _RightInputValue.y.ToString("00") + "," + _LeftInputValue.x.ToString("00") + "," + _LeftInputValue.y.ToString("00") + "," + _R1 + "," + _L1 + "," + _R2 + "," + _L2 + "," + _R3 + "," + _L3 + "," + _Ci + "," + _Cr + "," + _Sq + "," + _Tr + "," + _Ri + "," + _Do + "," + _Le + "," + _Up + "," + _Op + "," + _Sh;
        _sData = Encode(_message);
        //Debug.Log(_serialS._message);
    }
}
