using System;

namespace ExpenseTrackerApp
{
    // Tasks 1, 2 and 8 code here.
    [Flags]
    public enum ExpenseType
    {
      None=0,
      Travel=1,
      Meals=2,
      OfficeSupplies=4,
      Software=8,
      Entertainment=16
    }

    public enum ApprovalStage
    {
      Draft=1,
      Submitted=2,
      UnderReview=3,
      Approved=4,
      Rejected=5
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Expense Tracker App Running...");

            // Task 3-7, 9-16 code here.
            string[] listNames = Enum.GetNames(typeof(ExpenseType));
            foreach(string s in listNames){
              Console.WriteLine(s);
            }

              ExpenseType expenses = ExpenseType.Travel | ExpenseType.Meals;
              if((expenses & ExpenseType.Meals)==ExpenseType.Meals){
                Console.WriteLine("Expense includes: Meals");
              }else{
                Console.WriteLine("Expense does not include: Meals");
              }

              expenses &= ~ExpenseType.Meals;
              Console.WriteLine(expenses);

              if(Enum.TryParse("Meals | Software", out ExpenseType parsedExpense)){
                Console.WriteLine("Parsing was successfull!");
              }else{
                Console.WriteLine("ERROR");
              }

              Console.WriteLine();
              foreach(ApprovalStage i in Enum.GetValues(typeof(ApprovalStage))){
                Console.WriteLine(i);
              }

              Console.WriteLine();
              if(Enum.TryParse("Submitted",out ApprovalStage parsedStage)){
                Console.WriteLine("Parsed was a success!");

              }else{

                Console.WriteLine("Parsing wasn't a success!");

              }



              Console.WriteLine();

              int approvalValue =4;

              if(Enum.IsDefined(typeof(ApprovalStage),approvalValue)){
                ApprovalStage casted = (ApprovalStage)approvalValue;
                Console.WriteLine("The value was casted!");
              }else{
                Console.WriteLine("Value is not defined!");
              }

              ApprovalStage currentStage = ApprovalStage.UnderReview;
              currentStage = ApprovalStage.Rejected;

              switch(currentStage){
                case ApprovalStage.Draft:
                  Console.WriteLine("Cuurent stage: Draft");
                  break;
                case ApprovalStage.Submitted:
                  Console.WriteLine("Current stage:Submitted");
                  break;
                case ApprovalStage.UnderReview:
                  Console.WriteLine("Current stage: Under Review");
                  break;
                case ApprovalStage.Approved:
                  Console.WriteLine("Current stage: Approved");
                  break;
                case ApprovalStage.Rejected:
                  Console.WriteLine("Current stage: Rejected");
                  break;
                default:
                  Console.WriteLine("!UNKNOWN STAGE!");
                  break;
              }

              ExpenseType validExpense = ExpenseType.OfficeSupplies | ExpenseType.Software;
              if(Enum.IsDefined(typeof(ExpenseType),"Meals")){
                Console.WriteLine("Meals exists!");
              }else{
                Console.WriteLine("Meals does not exists!");
              }

              currentStage = ApprovalStage.Approved;
              Console.WriteLine(validExpense);
              Console.WriteLine(currentStage);

        }
    }
}
