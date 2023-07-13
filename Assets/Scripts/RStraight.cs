using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RStraight : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 4f;

    [SerializeField]
    private float direction = -1f;

    private Rigidbody2D carRigid;
    void Start()
    {
        carRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        RStraightMove();
    }

    private void RStraightMove()
    {
        Vector3 movePosition = new Vector3(transform.position.x + (direction * moveSpeed * Time.deltaTime), transform.position.y, 0f);
        transform.position = movePosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Break")
        {
            Destroy(this.gameObject);
        }
    }
}
