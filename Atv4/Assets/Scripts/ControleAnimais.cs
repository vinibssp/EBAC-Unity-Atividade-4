using UnityEngine;
using UnityEngine.InputSystem;

public class ControleAnimais : MonoBehaviour
{
    public enum TipoAnimal
    {
        Gato,
        Cachorro,
        Passaro
    }

    [Header("Configuração das Teclas")]
    public Key teclaGato = Key.Digit1;
    public Key teclaCachorro = Key.Digit2;
    public Key teclaPassaro = Key.Digit3;

    void Update()
    {
        if (Keyboard.current[teclaGato].wasPressedThisFrame)
        {
            ExibirMensagem(TipoAnimal.Gato);
        }
        else if (Keyboard.current[teclaCachorro].wasPressedThisFrame)
        {
            ExibirMensagem(TipoAnimal.Cachorro);
        }
        else if (Keyboard.current[teclaPassaro].wasPressedThisFrame)
        {
            ExibirMensagem(TipoAnimal.Passaro);
        }
    }

    void ExibirMensagem(TipoAnimal animalSelecionado)
    {
        switch (animalSelecionado)
        {
            case TipoAnimal.Gato:
                Debug.Log("Você escolheu o GATO! (Miau)");
                break;

            case TipoAnimal.Cachorro:
                Debug.Log("Você escolheu o CACHORRO! (Au Au)");
                break;

            case TipoAnimal.Passaro:
                Debug.Log("Você escolheu o PÁSSARO! (Piu Piu)");
                break;

            default:
                Debug.Log("Animal desconhecido.");
                break;
        }
    }
}