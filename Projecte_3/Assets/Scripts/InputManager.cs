using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager {
   public static bool Jump()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
