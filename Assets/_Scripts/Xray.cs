using UnityEngine;

public class Xray : MonoBehaviour
{
    public GameObject[] objectsToToggle; // Lista de objetos para activar o desactivar

    // Funci�n para activar o desactivar los objetos
    public void ToggleObjects(bool activate)
    {
        foreach (GameObject obj in objectsToToggle)
        {
            obj.SetActive(activate);
        }
    }

    // Funci�n para activar los objetos
    public void ActivateObjects()
    {
        ToggleObjects(true);
    }

    // Funci�n para desactivar los objetos
    public void DeactivateObjects()
    {
        ToggleObjects(false);
    }
}
