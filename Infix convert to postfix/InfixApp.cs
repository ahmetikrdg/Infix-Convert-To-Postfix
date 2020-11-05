using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infix_convert_to_postfix
{
    class InfixApp
    {
        static void Main(string[] args)
        {
            String input, output;
            while (true)
            {
                Console.Write("Enter infix: ");
                //System.out.flush();
                input= Console.ReadLine(); // read a string from kbd
                if (input.Equals("")) // quit if [Enter]
                    break;
                // make a translator
                InToPost theTrans = new InToPost(input);
                output = theTrans.doTrans(); // do the translation
                Console.WriteLine("Postfix is " + output + '\n');
            } // end while
        } // en
    }
}
