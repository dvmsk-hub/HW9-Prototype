namespace HW9_Prototype_pattern;

/// <summary>
/// Класс для описания потребительского микрокредита
/// </summary>
public class MicroConsumerLoan : Loan,IMyCloneable<MicroConsumerLoan>
{
    public string Guarantor;

    public MicroConsumerLoan()
    {
    }

    private MicroConsumerLoan(MicroConsumerLoan mcl) : base(mcl)
    {
        Guarantor = mcl.Guarantor;
    }

    public new MicroConsumerLoan Copy() => new (this);

    public new MicroConsumerLoan Clone() => new (this);

    
}