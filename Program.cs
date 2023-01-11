using System.IO.Pipes;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> likes = new List<string>();

            Console.WriteLine("Enter who liked your post");
            String answer = Console.ReadLine();
            
            
            while (answer != "")
            {
                likes.Add(answer);
                answer = Console.ReadLine();    
            }

            if (likes.Count == 0) {
                Console.WriteLine("Be first to like");
            }else if (likes.Count < 3)
            {
                string friends = "";
                foreach(string person in likes)
                {
                    friends += " " + person + ",";
                }
                Console.WriteLine(friends.Trim() + " liked you");
            }else
            {
                Console.WriteLine(likes[0] + ", " + likes[1] + " and other " + (likes.Count - 2) + " liked you"); ;
            }



        }
    }
}