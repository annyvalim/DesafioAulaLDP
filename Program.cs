using System.Runtime.CompilerServices;

Carro c1 = new Carro();
Carro c2 = new Carro();
Moto m1 = new Moto();
Moto m2 = new Moto();



List<Veiculo> veiculos = new List<Veiculo>();
veiculos.Add(c1);
veiculos.Add(c2);
veiculos.Add(m1);
veiculos.Add(m2);

foreach (var veiculo in veiculos)
{
    veiculo.Acelerar();
    veiculo.ExibirVelocidade();
    veiculo.Frear();
    veiculo.ExibirVelocidade();
}

