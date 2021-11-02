using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerInputController input;
    private CharacterController ch;
    public float rotation, speed;
    void Start()
    {
        input = GetComponent<PlayerInputController>();
        ch = GetComponent<CharacterController>();
    }
    public GameObject FollowTarget, head, target;
    private void Update()
    {
        FollowTarget.transform.rotation *= Quaternion.AngleAxis(input._look.x * rotation, Vector3.up);
        FollowTarget.transform.rotation *= Quaternion.AngleAxis(-input._look.y * rotation, Vector3.right);
        var angles = FollowTarget.transform.localEulerAngles;
        angles.z = 0;
        var angle = FollowTarget.transform.localEulerAngles.x;
        if (angle > 180 && angle < 300)
            angles.x = 300;
        else if (angle < 180 && angle > 60)
            angles.x = 60;
        FollowTarget.transform.localEulerAngles = angles;
        transform.rotation = Quaternion.Euler(0, FollowTarget.transform.rotation.eulerAngles.y, 0);
        FollowTarget.transform.localEulerAngles = new Vector3(angles.x, 0, 0);

        head.transform.rotation = FollowTarget.transform.rotation;

        Vector3 position = (transform.forward * input._move.y * speed) + (transform.right * input._move.x * speed);
        ch.Move(position * Time.deltaTime);
    }
}
