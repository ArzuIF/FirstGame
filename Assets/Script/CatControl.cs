using UnityEngine;

public class CatControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public float speed=0.0f;
    private Rigidbody2D _rigitbody2D;
    private Animator _animator;

    void Start(){
        _rigitbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 1;
            Debug.Log("Hiz 1.0f");
        }
        else
        {
            speed = 0.0f;
            Debug.Log("Hiz 0.0f");
        }
        _animator.SetFloat("Speed", speed);
        _rigitbody2D.linearVelocity = new Vector2(speed, 0f);
    }
}
