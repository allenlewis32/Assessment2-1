using System.Text;

namespace Assessment2_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the existing plate: ");
            string plate = Console.ReadLine();
            Console.Write("Enter the grouping number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Program.LicensePlate(plate, num));
        }
        public static string LicensePlate(string old, int n)
        {
            old = old.Replace("-", "").ToUpper();
            StringBuilder sb = new StringBuilder();
            int l = old.Length;
            int remaining = l % n;
            sb.Append(old.Substring(0, remaining));
            for (int i = remaining; i < l; i += n)
            {
                if (i != 0) { sb.Append('-'); }
                sb.Append(old.Substring(i, n));
            }
            return sb.ToString();
        }
    }
}