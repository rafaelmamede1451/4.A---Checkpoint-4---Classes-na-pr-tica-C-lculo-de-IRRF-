public class TabelaIRRF
{
    private readonly List<FaixaIRRF> _faixas;

    public TabelaIRRF()
    {
        _faixas = new List<FAixaIRRF>
        {
            new FaixaIRRF(0.00m, 3036.00m, 0.0m, 0.0m),
            new FaixaIRRF(3036.00m, 3533.31m, 0.075m, 182.16m),
            new FaixaIRRF(3533.31m, 4688.85m, 0.15m, 394.16m),
            new FaixaIRRF(4688.85m, 5830.85m, 0.225m, 675.49m),
            new FaixaIRRF(5830.85m, decimal.MaxValue, 0.275m, 908.73m)
        };
    }

    public FaixaIRRF ObterFaixa(decimal salarioBase)
    {
        return _faixas.First(f => f.Pertence(salarioBase));
    }
}
