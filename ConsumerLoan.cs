namespace HW9_Prototype_pattern;

/// <summary>
/// Класс для описания потребительского кредита 
/// </summary>
public class ConsumerLoan : Loan, IMyCloneable<ConsumerLoan>
{
    public string? Purpose;
    
    public ConsumerLoan()
    {
    }

    private ConsumerLoan(ConsumerLoan consumerloan) : base(consumerloan)
    {
        Purpose = consumerloan.Purpose;
    }

    public new ConsumerLoan Copy() => new (this);
    
    public new ConsumerLoan Clone() => new (this);

}