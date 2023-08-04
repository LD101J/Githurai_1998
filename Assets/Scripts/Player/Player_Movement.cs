using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    #region Variables
    [SerializeField] private Transform player_Transform;
    [SerializeField] private float limit_Value;
    #endregion
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Move_Player();
        }
    }

    private void Move_Player()
    {
        float halfScreen = Screen.width / 2;
        float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;
        float finalXPos = Mathf.Clamp(xPos * limit_Value, -limit_Value, limit_Value);
        player_Transform.localPosition = new Vector3(xPos, 0, 0);  
    }
}
