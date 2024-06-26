public class Carro : Veiculo
{
    public override void Acelerar()
    {
        velocidade += 10;
    }
    public override void Frear()
    {
        velocidade -= 5;
    }
}