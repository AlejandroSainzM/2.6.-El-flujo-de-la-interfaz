using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarEscena : MonoBehaviour
{
    public void Cargar(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
