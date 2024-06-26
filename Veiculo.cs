public abstract class Veiculo
{
    protected int velocidade;

    public abstract void Acelerar();
    public abstract void Frear();

    public void ExibirVelocidade()
    {
        Console.WriteLine($"Velocidade atual: {velocidade}");
    }

}