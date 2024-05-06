using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    private RotateMouse rotateMouse;
    private PlayerMove movement;
    private PickUpDrop is_grab;

    public GameObject soundUI;

    public AudioClip audioJump;
    public AudioSource playerAudio;

    bool wDown;
    Animator panim;
    Vector3 moveVec;
    public CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        UpdateRotate();
        UpdateMove();
        UpdateJump();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            JumpSound();
        }
        SoundManager();
    }

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rotateMouse = GetComponent<RotateMouse>();
        movement = GetComponent<PlayerMove>();
        panim = GetComponentInChildren<Animator>();
        is_grab = GameObject.FindWithTag("box").GetComponent<PickUpDrop>();
        characterController = GetComponent<CharacterController>();

    }

    private void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        if (!Mission2.is_ui)
        {
            rotateMouse.UpdateRotate(mouseX, mouseY);
        }
    }

    private void UpdateMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        wDown = Input.GetButton("Walk");
        

        moveVec = new Vector3(x, 0, z).normalized;
        if (is_grab.itemPickup == true)
        {
            panim.SetBool("isGrabWalk", moveVec != Vector3.zero);
        }
        else
        {
            if (wDown)
            {
                movement.moveSpeed = 5f;
            }
            else
            {
                movement.moveSpeed = 3f;
            }
            panim.SetBool("isWalk", moveVec != Vector3.zero);
            panim.SetBool("isRun", wDown);
        }
        movement.MoveTo(new Vector3(x, 0, z));
    }

    private void UpdateJump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            movement.Jump();
            panim.SetBool("isJump", true);
        }
        if(characterController.isGrounded)
        {
            panim.SetBool("isJump", false);

        }

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.CompareTag("box"))
        {
            is_grab = hit.gameObject.GetComponent<PickUpDrop>();
        }
        if(hit.gameObject.CompareTag("Dead"))
        {
            transform.position = new Vector3(0, 0, -5);
        }
    }

    public void JumpSound()
    {
        playerAudio.PlayOneShot(audioJump);
    }

    public void SoundManager()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Mission2.is_ui = true;
            Time.timeScale = 0;
            soundUI.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
