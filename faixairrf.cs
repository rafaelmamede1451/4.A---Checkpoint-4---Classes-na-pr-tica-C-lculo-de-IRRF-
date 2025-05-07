public class FaixaIRRF
{
    public decimal LimiteInferior { get; }
    public decimal LimiteSuperior { get; }
    public decimal Aliquota { get; }
    public decimal Deducao { get; }

    public FaixaIRRF(decimal limiteInferior, decimal limiteSuperior, decimal aliquota, decimal deducao)
    {
        LimiteInferior = limiteInferior;
        LimiteSuperior = limiteSuperior;
        Aliquota = aliquota;
        Deducao = deducao;
    }

    public bool Pertence(decimal salarioBase) =>
        salarioBase >= LimiteInferior && salarioBase <= LimiteSuperior;
}
