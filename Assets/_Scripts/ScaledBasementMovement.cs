using UnityEngine;

public class ScaledBasementMovement : MonoBehaviour
{
    public Transform referenceObject; // El objeto de referencia (la nave)
    public float moveMultiplier = 0.1f; // Factor de movimiento

    private Vector3 initialPosition; // Posición inicial del objeto

    private void Start()
    {
        initialPosition = transform.localPosition;
    }

    private void Update()
    {
        // Obtiene la diferencia de posición desde la posición inicial
        Vector3 deltaPosition = referenceObject.position - referenceObject.transform.position;

        // Aplica movimiento en las coordenadas locales (X y Z) multiplicado por el factor
        Vector3 newPosition = new Vector3(deltaPosition.x, 0f, deltaPosition.z) * moveMultiplier;

        // Suma la posición inicial para mantener la posición relativa
        transform.localPosition = initialPosition + newPosition;
    }
}
