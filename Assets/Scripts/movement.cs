using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontalMovement * Time.deltaTime * speed * -1, 0, verticalMovement * Time.deltaTime * speed * -1);
    }
}
