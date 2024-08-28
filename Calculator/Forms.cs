
namespace Calculator;

public class Forms
{
    private string? Operands; //'?' means that the variable can hold string or null.
    private double FNum;
    private double SNum;

    public void Inputs(){
        
        try{
             //Operation op = new Operation();
            Operation op = new(); // new expression
            Console.WriteLine("Enter the first number");
            FNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            SNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the operation");
            Operands = Console.ReadLine();
            var result = op.Execute(Operands, FNum, SNum);
            Console.WriteLine($"The result is {result}");
            //op.Execute(Operands, FNum, SNum);
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            Console.WriteLine("Thank you for using the calculator");
        }
    }
}
