using UnityEngine;

public class player_movement : MonoBehaviour
{

    public static Rigidbody2D rbody;
    public static Animator anim;
    private float attackTimeCounter;
    public float attackTime;
    public bool attacking;
    public Collider2D attackHitboxUp;
    public Collider2D attackHitboxDown;
    public Collider2D attackHitboxLeft;
    public Collider2D attackHitboxRight;
    public SpriteRenderer PlayerSprite;


    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        attackHitboxUp.enabled = false;
        attackHitboxDown.enabled = false;
        attackHitboxLeft.enabled = false;
        attackHitboxRight.enabled = false;
        PlayerSprite = gameObject.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Attacking();
        if(!attacking)
        {
            walking();
        }
    }

    void walking() {
            Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

            if (movement_vector != Vector2.zero)
            {

                anim.SetBool("isWalking", true);
                anim.SetFloat("input_x", movement_vector.x);
                anim.SetFloat("input_y", movement_vector.y);
            }
            else
            {
                anim.SetBool("isWalking", false);
            }
            rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime);
        }
    
       void Attacking()

        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Attacking");
                attackTimeCounter = attackTime;
                attacking = true;
                player_movement.rbody.velocity = Vector2.zero;
                player_movement.anim.SetBool("Attacking", true);
            }

            if (attackTimeCounter > 0)
            {
                attackTimeCounter -= Time.deltaTime;
            }

            if (attackTimeCounter < 0)
            {
                attacking = false;
                player_movement.anim.SetBool("Attacking", false);
                attackTimeCounter = 0;
            }

       
       
       
    }
}

