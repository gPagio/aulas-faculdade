namespace calculadora_oo.Operacoes;

internal class Divisao : Operacao
{
    public Divisao(double valor1, double valor2) : base(valor1, valor2)
    {
    }

    public override double Calcular(double valor1, double valor2)
    {
        return valor1 / valor2;
    }
}