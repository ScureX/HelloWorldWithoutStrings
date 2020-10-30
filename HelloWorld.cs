using System;
using System.Text;

namespace HelloWorldWithoutStrings
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                    ((char)(Encoding.ASCII.GetBytes(new char[] { ',' })[0] + Encoding.ASCII.GetBytes(new char[] { '<' })[0])).ToString() + "" +
                    ((char)(Encoding.ASCII.GetBytes(new char[] { ')' })[0] + Encoding.ASCII.GetBytes(new char[] { '<' })[0])).ToString() + "" +
                    ((char)(Encoding.ASCII.GetBytes(new char[] { '=' })[0] + Encoding.ASCII.GetBytes(new char[] { '/' })[0])).ToString() + "" +
                    ((char)(Encoding.ASCII.GetBytes(new char[] { '=' })[0] + Encoding.ASCII.GetBytes(new char[] { '/' })[0])).ToString() + "" +
                    ((char)(Encoding.ASCII.GetBytes(new char[] { '/' })[0] + Encoding.ASCII.GetBytes(new char[] { '@' })[0])).ToString() + "" +
                    ((char)(Encoding.ASCII.GetBytes(new char[] { '_' })[0] - Encoding.ASCII.GetBytes(new char[] { '?' })[0])).ToString() + "" +
                    ((char)(Encoding.ASCII.GetBytes(new char[] { ';' })[0] + Encoding.ASCII.GetBytes(new char[] { '<' })[0])).ToString() + "" +
                    ((char)(Encoding.ASCII.GetBytes(new char[] { '/' })[0] + Encoding.ASCII.GetBytes(new char[] { '@' })[0])).ToString() + "" +
                    ((char)(Encoding.ASCII.GetBytes(new char[] { ':' })[0] + Encoding.ASCII.GetBytes(new char[] { '8' })[0])).ToString() + "" +
                    ((char)(Encoding.ASCII.GetBytes(new char[] { '=' })[0] + Encoding.ASCII.GetBytes(new char[] { '/' })[0])).ToString() + "" +
                    ((char)(Encoding.ASCII.GetBytes(new char[] { ';' })[0] + Encoding.ASCII.GetBytes(new char[] { ')' })[0])).ToString());
            Console.ReadLine();
        }
    }
}