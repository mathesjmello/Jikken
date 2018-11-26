using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {

    public float MoveSpeed;
    public AudioSource As;
    public List<AudioClip> SonsPassoGrama, SonsPassoMadeira, SonsPassoCimento;
    CharacterController CharController;
    [SerializeField]  AnimationCurve JumpFallOf;
    [SerializeField]  float JumpMod;
    bool IsJumping;
    bool andando = false;
    public AudioSource walk;
    int numeroRandom;

    // Use this for initialization
    void Start () {
        CharController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        PlayerMovment();
        BasicRun();
    }

    void PlayerMovment()
    {
        float HInput = Input.GetAxis("Horizontal") * MoveSpeed ;
        float VInput = Input.GetAxis("Vertical") * MoveSpeed ;

        Vector3 FMovment = transform.forward * VInput;
        Vector3 RMovment = transform.right * HInput;

        CharController.SimpleMove(FMovment + RMovment);

        if (CharController.velocity.x == 0 || CharController.velocity.y == 0 && CharController.velocity.y == 0)
        {
            IsMoving();
        }
        else
        {
            As.Stop();
        }

        JumpImput();
    }

    void IsMoving()
    {
        //aqui coloca o som walk
        
    }

    void JumpImput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !IsJumping)
        {
            IsJumping = true;
            StartCoroutine(JumpEvent());
        }
    }

    IEnumerator JumpEvent()
    {
        float timeInAir = 0;

        CharController.slopeLimit = 90;

        do
        {
            float jumpForce = JumpFallOf.Evaluate(timeInAir);
            CharController.Move(Vector3.up * jumpForce * JumpMod * Time.deltaTime);
            timeInAir += Time.deltaTime;
            yield return null;
        }
        while (!CharController.isGrounded && CharController.collisionFlags != CollisionFlags.Above);

        CharController.slopeLimit = 45;
        IsJumping = false;
    }

    void BasicRun()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            MoveSpeed  = 12;
        }else
        {
            MoveSpeed = 6;
        }
    }

    
}



        if ((SceneManager.GetActiveScene().name=="cena"||SceneManager.GetActiveScene().name=="house_exterior")&& !As.isPlaying)
        {
            As.clip = SonsPassoGrama[Random.Range(0,SonsPassoGrama.Count)]; 
            As.Play();
        }
        if (SceneManager.GetActiveScene().name=="house_interior"&&!As.isPlaying)
        {
            As.clip = SonsPassoMadeira[Random.Range(0,SonsPassoGrama.Count)];
            As.Play();
        }
        if (SceneManager.GetActiveScene().name=="complexo"&&!As.isPlaying)
        {
            As.clip = SonsPassoCimento[Random.Range(0,SonsPassoGrama.Count)];
            As.Play();
        }
        