using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//싱글톤으로 만든게 하나 이미 있으므로 일반적인 C# 파일로 만듬
public class InputManager
{
    public Action KeyAction = null;

    public void OnUpdate()
    {
        if (Input.anyKey == false)
            return;

        if (KeyAction != null)
            KeyAction.Invoke();
    }
}
