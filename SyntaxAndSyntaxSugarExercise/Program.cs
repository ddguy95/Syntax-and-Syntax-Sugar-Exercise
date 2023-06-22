namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string response;
         if  (answer < 9)
            {
                response = answer + "is less than nine";
            }
         else
            {
                response = answer + "greater than or equal to nine";
            }
         //Console.WriteLine(response);
            /*-------------------------------------------------------------*/

            //Inferred Typing

            var answera = 4;
            var responsea = "";
            if (answera < 9)
            {
                responsea = ($"{answera} is less than nine");
            }
            else
            {
                responsea = ($"{answera} is greater than or equal to nine");
            }
         //Console.WriteLine(responsea);
            /*---------------------------------------------------------------*/

            // Ternary

            var answerb = 4;
            var responseb = "";

            responseb = (answerb < 9) ? ($"{answerb} is less than nine") : ($"{answerb} greater than or equal to nine");
            
            Console.WriteLine(responseb);



        }
    }
}
