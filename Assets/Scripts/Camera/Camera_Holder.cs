using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Holder : MonoBehaviour
{
    [SerializeField] private Transform player_Transform;
    private Vector3 initial_Rotation;

    private void Awake()
    {
        initial_Rotation = transform.eulerAngles;
    }
    private void Update()
    {
        transform.position = new Vector3(player_Transform.position.x, player_Transform.position.y, player_Transform.position.z);
        transform.eulerAngles = new Vector3(player_Transform.eulerAngles.x, player_Transform.eulerAngles.y + initial_Rotation.y, 0);
    }
}
