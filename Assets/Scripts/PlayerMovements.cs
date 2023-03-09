using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovements : MonoBehaviour
{

    [SerializeField]
    private float moveForce;
    [SerializeField]
    private float jumpForce;

    private float movementX;
    private float movementY;

    private Rigidbody2D rb;
    //private SpriteRenderer sr;
    private Animator anim;

    private string WALK_ANIMATION = "Walk";
    /*private string JUMP_ANIMATION = "Jump";*/

    private string GROUND_TAG = "Ground";
    private string ENEMY_TAG = "Enemy";

    private bool isGrounded;

    private void Awake()
    {
        Time.timeScale = 1;
        EnemySpawner.count = 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*PlayerMovementKeys();*/
        AnimatePlayer();
    }

    private void FixedUpdate()
    {
        PlayerJump();
    }

    /*void PlayerMovementKeys()
    {
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;
    }*/

    void AnimatePlayer()
    {

        if(isGrounded)
        {
            anim.SetBool(WALK_ANIMATION, true);
        }
        /*else if(movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
        }*/
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }

    void PlayerJump()
    {
        if((Input.GetButton("Jump")) && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag(ENEMY_TAG))
        {
            Time.timeScale = 0;
        }
    }

    

























}
