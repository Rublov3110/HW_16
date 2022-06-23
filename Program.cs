namespace HW_16
{
    public class Program
    {
        public static void Main()
        {
            MessageBox messageBox = new MessageBox((value) =>
            {
                if ((int)value == 0)
                {
                    Console.WriteLine("Cancel - Reject operation ");
                }
                else
                {
                    Console.WriteLine("OK - Operation confirmed");
                }
            });
            messageBox.Open();
            Console.ReadLine();
        }
    }
}
