using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Vector3 updatedPosition;

    public KillBoxScript killBox;
    public float speed;
    private float actualSpeed;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        updatedPosition = transform.position;
    }

    private int count;
    

    private void FixedUpdate()
    {
        updatedPosition.x += actualSpeed;
        transform.position = updatedPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("isWalking", true);
            actualSpeed = -1 * speed;
            spriteRenderer.flipX = true;
        } 
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) 
        {
            animator.SetBool("isWalking", true);
            actualSpeed = speed;
            spriteRenderer.flipX = false;
        }
        else
        {
            actualSpeed = 0;
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pressed space " + count + " times!");
            ++count;
            animator.SetBool("isAttacking", true);
            killBox.gameObject.SetActive(true);
        }

        if (!animator.GetBool("isAttacking"))
        {
            killBox.gameObject.SetActive(false);
        }
    }
}
