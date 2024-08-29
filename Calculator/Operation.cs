namespace Calculator;

public class Operation
{
    public double Execute(double FNum, double SNum, string? Operands){
        var result = Operands switch
        {
            "+" => Addition(FNum, SNum),
            "-" => Subtraction(FNum, SNum),
            "*" => Multiplication(FNum, SNum),
            "/" => Division(FNum, SNum),
            _ => throw new InvalidOperationException("Invalid operand"), // default
        };
        return result;
    
    }
    public double Addition(double FNum, double SNum) => FNum + SNum;
    public double Subtraction(double FNum, double SNum) => FNum - SNum;
    public double Multiplication(double FNum, double SNum) => FNum * SNum;
            
    public double Division(double FNum, double SNum){
            if(SNum == 0){
                throw new DivideByZeroException("Cannot divide by zero");
            }else{
                return FNum / SNum;
            }
    }

}
