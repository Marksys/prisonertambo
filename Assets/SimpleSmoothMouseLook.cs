using UnityEngine;

// Very simple smooth mouselook modifier for the MainCamera in Unity
// by Francis R. Griffiths-Keam - www.runningdimensions.com

[AddComponentMenu("Camera/Simple Smooth Mouse Look ")]
public class SimpleSmoothMouseLook : MonoBehaviour
{
    Vector2 _mouseAbsolute;
    Vector2 _smoothMouse;

    public bool isEnabled = true;
    public Vector2 clampInDegrees = new Vector2(360, 180);
    public bool lockCursor;
    public Vector2 sensitivity = new Vector2(2, 2);
    public Vector2 smoothing = new Vector2(3, 3);
    public Vector2 targetDirection;
    public Vector2 targetCharacterDirection;

    //variveis colisao parede
    public bool NaoTemColisao = true;
    public Vector3 posicaoInicialCameraLocal;
    public Transform posicaoCameraColisao;

    //variaveis lerp
    float lerpTime = 0.3f;
    float currentLerpTime;
    float currentLerpTimeSC;
    float perc;
    bool finalizouLerp = true;
    //

    // Assign this if there's a parent object controlling motion, such as a Character Controller.
    // Yaw rotation will affect this object instead of the camera if set.
    public GameObject characterBody;

    void Start()
    {
        posicaoInicialCameraLocal = transform.localPosition;
        // Set target direction to the camera's initial orientation.
        targetDirection = transform.localRotation.eulerAngles;

        // Set target direction for the character body to its inital state.
        if (characterBody) targetCharacterDirection = characterBody.transform.localRotation.eulerAngles;

        lockCursor = true;
    }

    void Update()
    {
        if (isEnabled)
        {
            if (NaoTemColisao)
            {
                currentLerpTime = 0f;
                currentLerpTimeSC += Time.deltaTime;
                if (currentLerpTimeSC > lerpTime)
                {
                    currentLerpTimeSC = lerpTime;

                    finalizouLerp = true;
                }

                if (!finalizouLerp)
                    transform.LookAt(characterBody.transform);

                perc = currentLerpTimeSC / lerpTime;
                transform.localPosition = Vector3.Lerp(posicaoCameraColisao.localPosition, posicaoInicialCameraLocal, perc);
            }
            else
            {
                finalizouLerp = false;
                currentLerpTimeSC = 0f;
                currentLerpTime += Time.deltaTime;
                if (currentLerpTime > lerpTime)
                {
                    currentLerpTime = lerpTime;
                }
                perc = currentLerpTime / lerpTime;

                transform.localPosition = Vector3.Lerp(posicaoInicialCameraLocal, posicaoCameraColisao.localPosition, perc);
                transform.localRotation = posicaoCameraColisao.localRotation;
            }


            // Ensure the cursor is always locked when set
            if (lockCursor)
                Cursor.lockState = CursorLockMode.Locked;
            else
                Cursor.lockState = CursorLockMode.None;

            // Allow the script to clamp based on a desired target value.
            var targetOrientation = Quaternion.Euler(targetDirection);
            var targetCharacterOrientation = Quaternion.Euler(targetCharacterDirection);

            // Get raw mouse input for a cleaner reading on more sensitive mice.
            var mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

            if (!NaoTemColisao) //evita quando voltar tiver olhando para a lua
                mouseDelta.y = 0f;

            // Scale input against the sensitivity setting and multiply that against the smoothing value.
            mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity.x * smoothing.x, sensitivity.y * smoothing.y));

            // Interpolate mouse movement over time to apply smoothing delta.
            _smoothMouse.x = Mathf.Lerp(_smoothMouse.x, mouseDelta.x, 1f / smoothing.x);
            _smoothMouse.y = Mathf.Lerp(_smoothMouse.y, mouseDelta.y, 1f / smoothing.y);

            // Find the absolute mouse movement value from point zero.
            _mouseAbsolute += _smoothMouse;

            // Clamp and apply the local x value first, so as not to be affected by world transforms.
            if (clampInDegrees.x < 360)
                _mouseAbsolute.x = Mathf.Clamp(_mouseAbsolute.x, -clampInDegrees.x * 0.5f, clampInDegrees.x * 0.5f);

            var xRotation = Quaternion.AngleAxis(-_mouseAbsolute.y, targetOrientation * Vector3.right);

            if (NaoTemColisao)
                transform.localRotation = xRotation;

            // Then clamp and apply the global y value.
            if (clampInDegrees.y < 360)
                _mouseAbsolute.y = Mathf.Clamp(_mouseAbsolute.y, -clampInDegrees.y * 0.5f, clampInDegrees.y * 0.5f);

            if (NaoTemColisao)
                transform.localRotation *= targetOrientation;

            // If there's a character body that acts as a parent to the camera
            if (characterBody)
            {
                var yRotation = Quaternion.AngleAxis(_mouseAbsolute.x, characterBody.transform.up);
                characterBody.transform.localRotation = yRotation;
                characterBody.transform.localRotation *= targetCharacterOrientation;
            }
            else
            {
                var yRotation = Quaternion.AngleAxis(_mouseAbsolute.x, transform.InverseTransformDirection(Vector3.up));
                transform.localRotation *= yRotation;
            }
        }
    }

    void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}