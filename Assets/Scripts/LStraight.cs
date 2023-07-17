using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LStraight : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 4f;

    [SerializeField]
    private float direction = 1f;

    public bool LSGO = false;

    private bool isMoving = true;
    private Rigidbody2D carRigid;
    void Start()
    {
        carRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(isMoving == true)
        {
        LStraightMove();
        }
    }

    private void LStraightMove()
    {
        Vector3 movePosition = new Vector3(transform.position.x + (direction * moveSpeed * Time.deltaTime), transform.position.y, 0f);
        transform.position = movePosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Break")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.CompareTag("Blocker"))
        {
           
            if (LSGO == false)
            {
                Debug.Log("멈추라고");
                isMoving = false;
            }

            StartCoroutine(WaitForLSgo());
        }
    }

    private IEnumerator WaitForLSgo()
    {
        while (LSGO == false)
        {
            yield return null;
        }

        isMoving = true;
    }
}
