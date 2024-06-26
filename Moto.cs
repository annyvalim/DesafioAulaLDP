public class Moto : Veiculo
{
    public override void Acelerar()
    {
        velocidade += 15;
    }
    public override void Frear()
    {
        velocidade -= 10;
    }
}