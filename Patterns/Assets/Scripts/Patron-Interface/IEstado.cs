//La clase base de los estados
//Todos los estados tendrán lo que dice aqui
//Es una plantilla de los estados
public interface IEstado
{

    void Entrar(SemaforoStateMachine semaforo);
    void Ejecutar(SemaforoStateMachine semaforo);
    void Salir(SemaforoStateMachine semaforo);
}
