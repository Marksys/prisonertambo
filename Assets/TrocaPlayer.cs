using UnityEngine;
using System.Collections;

public class TrocaPlayer : MonoBehaviour {

	public MoveChar AdamMove;
	public MoveChar LauraMove;
	public Camera _camera;
	public Transform _cameraAdamFirst;
	public Transform _cameraLauraFirst;
	private Vector3 _cameraAdamPosLast;
	private Vector3 _cameraLauraPosLast;
	private Quaternion _cameraAdamRotLast;
	private Quaternion _cameraLauraRotLast;
	public int CharAtivo;
	public GameObject Mensagem;
	public GameObject Terminal;
    public EstadoJogoGO estadoJogo;
    public GameObject MensagemSairJogo;
	
	private float nextFire;
	
	// Use this for initialization
	void Start () {
		CharAtivo = 0;//adam, se for comecar com outro, trocar;
		
		//copia as posicoes das cameras localmente, se mexer no transform do First, mexe na posicao da camera
		_cameraAdamPosLast = _cameraAdamFirst.position;
		_cameraAdamRotLast = _cameraAdamFirst.rotation;
		_cameraLauraPosLast = _cameraLauraFirst.position;
		_cameraLauraRotLast = _cameraLauraFirst.rotation;	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetButton("Change") && Time.time > nextFire && !MensagemSairJogo.activeSelf)
		{
			nextFire = Time.time + 1f; //soh para nao ficar trocando loucamente..
			
			if(CharAtivo == 0) //trocar para laura
			{
				CharAtivo = 1;
				LauraMove.PodeMover = true;
				AdamMove.PodeMover = false;
                estadoJogo._movechar = LauraMove;
                _cameraAdamPosLast = _camera.transform.position;
				_cameraAdamRotLast = _camera.transform.rotation;				
				_camera.transform.position = _cameraLauraPosLast;
				_camera.transform.rotation = _cameraLauraRotLast;	
				_camera.GetComponent<CameraLook>().target = LauraMove.transform;				
			}
			else if(CharAtivo == 1) //trocar para adam
			{
				CharAtivo = 0;
				AdamMove.PodeMover = true;
				LauraMove.PodeMover = false;
                estadoJogo._movechar = AdamMove;
                _cameraLauraPosLast = _camera.transform.position;
				_cameraLauraRotLast = _camera.transform.rotation;				
				_camera.transform.position = _cameraAdamPosLast;
				_camera.transform.rotation = _cameraAdamRotLast;
				_camera.GetComponent<CameraLook>().target = AdamMove.transform;				
			}
			
			Mensagem.SetActive(false);
			Terminal.SetActive(false);
		}
	}
}
