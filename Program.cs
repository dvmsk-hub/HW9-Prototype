namespace HW9_Prototype_pattern;

class Program
{
    static void Main(string[] args)
    {
        var loan = new Loan()
        {
            BrandName = "Кредит"
        };
        
        Console.WriteLine($"Основа: {loan.BrandName}");
        var standartCopyLoan = (Loan)loan.Clone();
        Console.WriteLine($"Копия ICloneable: {standartCopyLoan.BrandName}");
        var copyLoan = loan.Copy();
        Console.WriteLine($"Копия IMyCloneable: {copyLoan.BrandName}");
        
        Console.WriteLine($"----------------------------------------------");
        

        var consumerLoan = new ConsumerLoan()
        {
            BrandName = "Потребительский кредит",
            Purpose = "Ремонт"
        };
        
        Console.WriteLine($"Основа: {consumerLoan.BrandName} Цель кредита: {consumerLoan.Purpose}");
        var standartCopyConsumerLoan = consumerLoan.Clone();
        Console.WriteLine($"Копия ICloneable: : {standartCopyConsumerLoan.BrandName} Цель кредита: {standartCopyConsumerLoan.Purpose}");
        var copyConsumerLoan = consumerLoan.Copy();
        Console.WriteLine($"Копия IMyCloneable: {copyConsumerLoan.BrandName} Цель кредита: {copyConsumerLoan.Purpose}");
        
        Console.WriteLine($"----------------------------------------------");
        
        var microConsumerLoan = new MicroConsumerLoan()
        {
            BrandName = "Потребительский кредит",
            Guarantor = "Супруга"
        };
        
        Console.WriteLine($"Основа: {microConsumerLoan.BrandName} Поручитель: {microConsumerLoan.Guarantor}");
        var standertCopyMicroConsumerLoan = microConsumerLoan.Clone();
        Console.WriteLine($"Копия ICloneable: {standertCopyMicroConsumerLoan.BrandName} Поручитель: {standertCopyMicroConsumerLoan.Guarantor}");
        var copyMicroConsumerLoan = microConsumerLoan.Copy();
        Console.WriteLine($"Копия IMyCloneable: {copyMicroConsumerLoan.BrandName} Поручитель: {copyMicroConsumerLoan.Guarantor}");


    }
}