using UnityEngine;

public class ScaledBasementMovement : MonoBehaviour
{
    public Transform referenceObject; // El objeto de referencia (la nave)
    public float moveMultiplier = 0.1f; // Factor de movimiento

    private Vector3 initialPosition; // Posici�n inicial del objeto

    private void Start()
    {
        initialPosition = transform.localPosition;
    }

    private void Update()
    {
        // Obtiene la diferencia de posici�n desde la posici�n inicial
        Vector3 deltaPosition = referenceObject.position - referenceObject.transform.position;

        // Aplica movimiento en las coordenadas locales (X y Z) multiplicado por el factor
        Vector3 newPosition = new Vector3(deltaPosition.x, 0f, deltaPosition.z) * moveMultiplier;

        // Suma la posici�n inicial para mantener la posici�n relativa
        transform.localPosition = initialPosition + newPosition;
    }
}
