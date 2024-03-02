namespace HW9_Prototype_pattern;

/// <summary>
/// Kласс для описания банковского кредита 
/// </summary>
public class Loan : IMyCloneable<Loan>, ICloneable
{
    public string BrandName;
    
    public Loan()
    {
        
    }

    protected Loan(Loan loan)
    {
        BrandName = loan.BrandName;
    }
    
    public Loan Copy() => new (this);

    public object Clone() => new Loan(this);
    
}