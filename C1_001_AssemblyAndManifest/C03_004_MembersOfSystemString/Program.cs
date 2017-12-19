using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_004_MembersOfSystemString
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            VerbatimStrings();
            StringEquality();

            JoachimStringFunctionality();
            StringConcatenation();
            EscapeChars();

            Console.WriteLine("=> Verbatim Strings:");
            // The following string is printed verbatim,
            // thus all escape characters are displayed.
            Console.WriteLine(@"C:\MyApp\bin\Debug");

            // White space is preserved with verbatim strings.
            string myLongString = @"This is a very
            very
                    very
                            long string";
            Console.WriteLine(myLongString);

            // Using verbatim strings, you can also directly insert a double quote into a literal string by doubling
            // the " token.
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");

            string s = @"Foo sagte ""Bar""";
            Console.WriteLine(s);

            Console.WriteLine();
            StringEquality();

            StringsAreImmutable();
            StringsAreImmutable2();

            Console.WriteLine();

        }



        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }

        static void JoachimStringFunctionality()
        {
            string myString = "Full power";
            string myOtherString = "Awesome";
            string myTestString = "blabla";

            Console.WriteLine(myString.Contains("l"));
            Console.WriteLine(String.Compare(myString, myOtherString));
            Console.WriteLine(myString.Equals(myOtherString));

            Console.WriteLine(myTestString.Insert(3, myOtherString));
            Console.WriteLine(myString.PadLeft(15, '0'));

            Console.WriteLine(myString.Remove(5, 5));
            Console.WriteLine();
        }

        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \"Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            // Adds a total of 4 blank lines (then beep again!).
            Console.WriteLine("All finished.\n\n\n\a ");
            Console.WriteLine();
        }

        static void VerbatimStrings()
        {
            // The following string is printed verbatim,
            // thus all escape characters are displayed.
            Console.WriteLine(@"C:\MyApp\bin\Debug");

            // White space is preserved with verbatim strings.
            string myLongString = @"This is a very
                very
                        very
                                long string";
            Console.WriteLine(myLongString);

            // Wörtliche Rede
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
            Console.WriteLine();
        }



        static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            // Test these strings for equality.
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();

            Console.WriteLine("Eigene String Vergleich Tests:");
            string foo = "foo";
            string bar = "bar";

            Console.WriteLine("foo == foo: {0}", foo == foo); // true
            Console.WriteLine("foo == bar: {0}", foo == bar); // false

            string foo2 = "Foo";
            Console.WriteLine("Foo == foo: {0}", foo2 == foo); // false
            Console.WriteLine("foo equals bar: {0}", foo.Equals(bar));  // false
            Console.WriteLine("foo equals foo: {0}", "foo".Equals(foo)); // true
            Console.WriteLine();
        }

        static void StringsAreImmutable()
        {
            // Set initial string value.
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);
            // Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);
            // Nope! s1 is in the same format!
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine();
        }

        static void StringsAreImmutable2()
        {
            string s2 = "My other string";
            s2 = "New string value";
            Console.WriteLine(s2);
        }

        static void FunWithStringBuilder()
        {

            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("****Fantastic Games****", 256);


        }
    }
}

