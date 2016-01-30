using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveChar : MonoBehaviour {
	
	float rotateSpeed = 4; // Speed to rotate at.
	float speed = 2; // Speed to move at.
	
	CharacterController controller;
	Animator animator;
	
	public GameObject holderMensagem;
	public GameObject holderTerminal;
	public Text _mensagem;
	
	public bool PodeMover = true;
	public bool AcabouSairMenu = false;
	
	public CallTerminal _lastTerminal;
	
	public int CharId;
	
	/*Movimentacao 1*/	
	Vector3 forward;
	float curSpeed;
	bool isRunning;
	float timeDelayRun;
	float gravidade;
	/*-------------*/
	
	/*Movimentacao 2*/
	private Quaternion newrotation;
	private float smooth = 0.05f;
	public Transform cameraAngle;
    /*-------------*/

    public SimpleSmoothMouseLook mouseLook;
	
	void Awake()
	{
		controller = gameObject.GetComponent<CharacterController>();
		animator = gameObject.GetComponent<Animator>();		
	}
	
	float timerMenu = 0f;
	void Update()
	{
		//gambi para nao ficar em looping quando sair do menu
		if(AcabouSairMenu && timerMenu == 0f)
			timerMenu = Time.time;
			
		if(timerMenu > 0f && (Time.time - timerMenu) > 0.5f)
		{
			AcabouSairMenu = false;
			timerMenu = 0f;
		}
		//fim da gambi
	}

    float timeIdle = 0;
    float axis = 0f;
    float axisX = 0f;
    Vector3 side;
    void FixedUpdate()
	{
        if (PodeMover && controller.isGrounded) //movimentacao tank
        {
            mouseLook.enabled = true;
            mouseLook.lockCursor = true;
            //if (curSpeed < 0.1f)
            //    rotateSpeed = 4;
            //if (curSpeed < 1.7f)
            //    rotateSpeed = 3;
            //else
            //    rotateSpeed = 2;

            axis = Input.GetAxis("Vertical");
            axisX = Input.GetAxis("Horizontal");
            //transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

            forward = transform.TransformDirection(Vector3.forward);
            if (axisX < 0)
                side = transform.TransformDirection(Vector3.left);
            if (axisX > 0)
                side = transform.TransformDirection(Vector3.right);

            curSpeed = speed * (axis / 1.25f);

            if (curSpeed < 0.5f) //se a velocidade zerar, nao pode estar correndo, isso acontecer em teletransporte
            {
                isRunning = false;
                timeDelayRun = 0f;
            }

            if (Input.GetButton("Run") && !isRunning)
                timeDelayRun = Time.time;
            else if (!Input.GetButton("Run"))
                timeDelayRun = 0f;

            isRunning = Input.GetButton("Run");

            if (curSpeed > 1.2f || curSpeed < -1f)
            {
                if (curSpeed > 0 && isRunning && ((Time.time - timeDelayRun) > 0.55f))
                {
                    curSpeed *= 2;
                }
            }

            if (curSpeed > 0.05f || curSpeed < -0.05f)
                controller.SimpleMove(forward * curSpeed);

            if (axisX < -0.05f)
                controller.SimpleMove(side * axisX * -1 * speed);

            if (axisX > 0.05f)
                controller.SimpleMove(side * axisX * speed);

            //isso faz um timezinho para saber se o cara vai ficar parado mesmo, ou se está apenas mudando de botao
            if (axis == 0 && axisX == 0)
            {
                if (timeIdle == 0)
                    timeIdle = Time.time;
            }
            else
                timeIdle = 0f;

            if (timeIdle != 0 && Time.time - timeIdle > 0.2f)
                animator.SetBool("IsStopped", true);
            else
            {
                animator.SetBool("IsStopped", false);
            }
            //fim de verificacao se vai ficar parado

            animator.SetBool("IsRunning", isRunning);
            animator.SetFloat("Speed", curSpeed);
            animator.SetFloat("Axis", axis);
            animator.SetFloat("AxisX", axisX);          
        }      
        /*
		if(PodeMover) //movimentacao com angulo direto...
		{
			float v = Input.GetAxis ("Vertical");
			float h = Input.GetAxis ("Horizontal");
			movement(v,h); 
		}
		
		if(PodeMover && controller.isGrounded) //movimentacao tank
		{
            if (curSpeed < 0.1f)
                rotateSpeed = 4;
			if(curSpeed < 1.7f)
				rotateSpeed = 3;
			else
				rotateSpeed = 2;
            axis = Input.GetAxis("Vertical");
            transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0); 
			forward = transform.TransformDirection(Vector3.forward); 
			curSpeed = speed * (axis / 1.25f);
			
			if(curSpeed < 0.5f) //se a velocidade zerar, nao pode estar correndo, isso acontecer em teletransporte
			{
				isRunning = false;
				timeDelayRun = 0f;
			}
			
			if(Input.GetButton("Run") && !isRunning)
				timeDelayRun = Time.time;
			else if(!Input.GetButton("Run"))
				timeDelayRun = 0f;
			
			isRunning = Input.GetButton("Run");
			
			if(curSpeed > 1.2f || curSpeed < -1f)
			{
				if(curSpeed > 0 && isRunning && ((Time.time - timeDelayRun) > 0.55f ))
				{
					curSpeed *= 2;
				}				
			}

            if(curSpeed > 0.05f || curSpeed < -0.05f)
                controller.SimpleMove(forward * curSpeed);

            //isso faz um timezinho para saber se o cara vai ficar parado mesmo, ou se está apenas mudando de botao
            if (axis == 0) 
            {
                if(timeIdle == 0)
                    timeIdle = Time.time;
            }
            else
                timeIdle = 0f;
            
            if (timeIdle != 0 && Time.time - timeIdle > 0.2f)
                animator.SetBool("IsStopped", true);
            else
            {
                animator.SetBool("IsStopped", false);
            }
            //fim de verificacao se vai ficar parado

            animator.SetBool ("IsRunning", isRunning);
			animator.SetFloat ("Speed", curSpeed);
            animator.SetFloat("Axis", axis);
        }*/
        
		else
		{
			animator.SetBool ("IsRunning", false);
			animator.SetFloat ("Speed", 0f);
            animator.SetFloat("Axis", 0f);
            animator.SetBool("IsStopped", true);
            timeDelayRun = 0f;
            mouseLook.lockCursor = false;
            mouseLook.enabled = false;
        }

        //gravidade, para o player cair		
        if (!controller.isGrounded)
		{
			gravidade -= 0.09f * Time.deltaTime;
			controller.Move(new Vector3(0,gravidade,0));
		}
	}
	
	void movement (float v, float h) 
	{
		if (h != 0f || v != 0f) 
		{
            print("teste");
            animator.SetBool("IsStopped", false);
            rotate(v,h);			
			animator.SetFloat ("Speed",1.6f);		
			curSpeed = 1.6f;
			
			if(Input.GetButton("Run") && !isRunning)
				timeDelayRun = Time.time;
			else if(!Input.GetButton("Run"))
				timeDelayRun = 0f;
			
			isRunning = Input.GetButton("Run");			
			animator.SetBool ("IsRunning", isRunning);
			
			if(curSpeed > 0 && isRunning && ((Time.time - timeDelayRun) > 0.55f ))
			{
				curSpeed *= 2;				
			}
			
			controller.SimpleMove(transform.TransformDirection(Vector3.forward) * curSpeed);        
		}
		else 
		{
            animator.SetBool("IsStopped", true);
            animator.SetFloat ("Speed",0);
		}
	}
	
	void rotate(float v,float h) 
	{
		if (v > 0) 
		{
			if (h > 0) 
			{
				newrotation = Quaternion.Euler(0,cameraAngle.eulerAngles.y+45,0);
			} 
			else if (h < 0) 
			{
				newrotation = Quaternion.Euler(0,cameraAngle.eulerAngles.y+305,0);
			}
			else 
			{
				newrotation = Quaternion.Euler(0,cameraAngle.eulerAngles.y,0);
			}
		} 
		else if (v < 0) 
		{
			if (h > 0) 
			{
				newrotation = Quaternion.Euler(0,cameraAngle.eulerAngles.y+135,0);
			}
			else if (h < 0) 
			{
				newrotation = Quaternion.Euler(0,cameraAngle.eulerAngles.y+225,0);
			}
			else {
				newrotation = Quaternion.Euler(0,cameraAngle.eulerAngles.y+180,0);
			}
		}
		else 
		{
			if (h > 0) 
			{
				newrotation = Quaternion.Euler(0,cameraAngle.eulerAngles.y+90,0);
			}
			else if (h < 0) 
			{
				newrotation = Quaternion.Euler(0,cameraAngle.eulerAngles.y+270,0);
			}
			else {
				newrotation = transform.rotation;
			}
		}
		
		newrotation.x = 0;
		newrotation.z = 0;
		//We only want player to rotate in y axis 
		transform.rotation = Quaternion.Slerp (transform.rotation, newrotation, smooth); 
		//Slerp from player's current rotation to the new intended rotaion smoothly 
	}
	
	float rayLength = 1f;
	public void OnTriggerStay(Collider other)
	{	
		if((other.tag == "ItemGet" || other.tag == "Terminal") && !AcabouSairMenu && PodeMover)
		{
			RaycastHit hit = new RaycastHit();
			Vector3 fwd = transform.TransformDirection(Vector3.forward+Vector3.up);
			Debug.DrawRay(transform.position, fwd, Color.green);
			
			if(Physics.Raycast(transform.position , fwd, out hit, rayLength))
			{
				AtivaPlayerOlhando(true, other);
			}
			else
				AtivaPlayerOlhando(false, other);
		}
	}
	
	public void OnTriggerExit(Collider other)
	{
		AtivaPlayerOlhando(false, other);
	}
	
	private void AtivaPlayerOlhando(bool status, Collider other)
	{
		if(other.tag == "ItemGet")
		{
			other.GetComponent<GetPenDrive>().PlayerOlhando = status;
			other.GetComponent<GetPenDrive>()._holderMensagem = holderMensagem;
            _mensagem.text = Textos.GetPenDrive;			
			holderMensagem.SetActive (status);
		}
		else if(other.tag == "Terminal")
		{
            _lastTerminal = other.GetComponent<CallTerminal>();
			_lastTerminal.scriptMove = this;
			int idNivelTerminal = _lastTerminal.NivelTerminal;
			
			if(idNivelTerminal == 0)
			{
				if(EstadoJogo.HasPenDrive)
				{
					_lastTerminal.PlayerOlhando = status;		
					_mensagem.text = Textos.UseTerminal; 
					
					if(holderTerminal.activeSelf)
						holderMensagem.SetActive(false);
					else
						holderMensagem.SetActive (status);
				}
				else
				{
                    _mensagem.text = Textos.CannotUseThisTerminal;	
					holderMensagem.SetActive (status);
				}
			}
			else if(idNivelTerminal == 1)
			{
				if(EstadoJogo.HasPenDrive2)
				{
					_lastTerminal.PlayerOlhando = status;		
					_mensagem.text = Textos.UseTerminal;

                    if (holderTerminal.activeSelf)
						holderMensagem.SetActive(false);
					else
						holderMensagem.SetActive (status);
				}
				else
				{	
					_mensagem.text = Textos.CannotHackTerminal;
                    holderMensagem.SetActive (status);
				}
			}			
		}
	}
	
	//este eh o push das bolas
	void OnControllerColliderHit(ControllerColliderHit hit){
		if (hit.rigidbody && hit.collider.tag == "Push"){
			var dir = hit.normal; // get the hit direction
			dir.y = 0; // consider only the horizontal direction
			hit.rigidbody.AddForce(10f * dir.normalized);
		}
	}
}
