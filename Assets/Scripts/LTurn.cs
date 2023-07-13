using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LTurn : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 4f;

    [SerializeField]
    private float direction = 1f;

    private Rigidbody2D carRigid;
    private SpriteRenderer carSpriteRenderer;

    void Start()
    {
        carRigid = GetComponent<Rigidbody2D>();
        carSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        LTurnMove();
    }

    private void LTurnMove()
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Turn"))
        {
            carSpriteRenderer.transform.rotation = Quaternion.Euler(0f, 0f, -90f);
            Vector3 moveposition =  new Vector3(transform.position.x, transform.position.y - (direction * moveSpeed * Time.deltaTime), 0f);
        }
    }
}