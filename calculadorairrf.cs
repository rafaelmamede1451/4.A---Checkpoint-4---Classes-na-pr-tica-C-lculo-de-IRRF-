public class CalculadoraIRRF
{
    private readonly TabelaIRRF _tabelaIRRF;

    public CalculadoraIRRF()
    {
        _tabelaIRRF = new TabelaIRRF();
    }

    public decimal Calcular(decimal salarioBruto, decimal descontoINSS)
    {
        decimal salarioBase = salarioBruto - descontoINSS;
        FaixaIRRF faixa = _tabelaIRRF.ObterFaixa(salarioBase);

        decimal irrf = salarioBase * faixa.Aliquota - faixa.Deducao;
        return Math.Max(irrf, 0); // IRRF não pode ser negativo
    }
}
