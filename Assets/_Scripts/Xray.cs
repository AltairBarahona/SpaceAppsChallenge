using UnityEngine;

public class Xray : MonoBehaviour
{
    public GameObject[] objectsToToggle; // Lista de objetos para activar o desactivar

    // Función para activar o desactivar los objetos
    public void ToggleObjects(bool activate)
    {
        foreach (GameObject obj in objectsToToggle)
        {
            obj.SetActive(activate);
        }
    }

    // Función para activar los objetos
    public void ActivateObjects()
    {
        ToggleObjects(true);
    }

    // Función para desactivar los objetos
    public void DeactivateObjects()
    {
        ToggleObjects(false);
    }
}
