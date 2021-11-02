using System;
using System.Collections.Generic;
using System.Linq;

namespace DPS002AnagramToInteger
{
    class Program
    {

        //Problem description #359
        //This problem was asked by Slack.
        //You are given a string formed by concatenating several words corresponding to the integers zero through nine and then anagramming.
        //For example, the input could be 'niesevehrtfeev', which is an anagram of 'threefiveseven'. Note that there can be multiple instances of each integer.
        //Given this string, return the original integers in sorted order. In the example above, this would be 357.

        static void Main(string[] args)
        {
            string output = string.Empty;

            int oneCount = 0;
            int twoCount = 0;
            int threeCount = 0;
            int fourCount = 0;
            int fiveCount = 0;
            int sixCount = 0;
            int sevenCount = 0;
            int eightCount = 0;
            int nineCount = 0;
            IDictionary<string, int> numberNames = new Dictionary<string, int>();

            string str = "niesevehrtfeevvifoneeon";
            Console.WriteLine("String: " + str);

            while (str.Length > 0)
            {
                int cal = 0;
                for(int j = 0; j < str.Length; j++)
                {
                    if(str[0]== str[j])
                    {
                        cal++;
                    }
                }
                numberNames.Add(str[0].ToString(), cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }


            //For One
           
                int oforOne = numberNames.ContainsKey("o") ? numberNames["o"] : 0;
                int nforOne = numberNames.ContainsKey("n") ? numberNames["n"] : 0;
                int eforOne = numberNames.ContainsKey("e") ? numberNames["e"] : 0;
                while (oforOne > 0 && nforOne > 0 && eforOne > 0)
                {
                        oneCount = oneCount + 1;
                        numberNames["o"] = numberNames["o"] - 1;
                        numberNames["n"] = numberNames["n"] - 1;
                        numberNames["e"] = numberNames["e"] - 1;
                        oforOne = oforOne - 1;
                        nforOne = nforOne - 1;
                        eforOne = eforOne - 1;
                }

            //For Two

            int tfortwo = numberNames.ContainsKey("t") ? numberNames["t"]:0;
            int wfortwo = numberNames.ContainsKey("w") ? numberNames["w"]:0;
            int ofortwo = numberNames.ContainsKey("o") ? numberNames["o"]:0;

            while (tfortwo > 0 && wfortwo > 0 && ofortwo > 0)
            {
                twoCount = twoCount + 1;
                numberNames["t"] = numberNames["t"] - 1;
                numberNames["w"] = numberNames["w"] - 1;
                numberNames["o"] = numberNames["o"] - 1;

                tfortwo = tfortwo -1;
                wfortwo = wfortwo -1;
                ofortwo = ofortwo -1;

            }


            //For Three

            int tforThree = numberNames.ContainsKey("t") ? numberNames["t"]:0;
            int hforThree = numberNames.ContainsKey("h") ? numberNames["h"]:0;
            int rforeThree = numberNames.ContainsKey("r") ? numberNames["r"]:0;
            int eforeThree = numberNames.ContainsKey("e") ? numberNames["e"]:0;

            while (tforThree > 0 && hforThree > 0 && rforeThree > 0 && eforeThree > 1)
            {
                threeCount = threeCount + 1;
                numberNames["t"] = numberNames["t"] - 1;
                numberNames["h"] = numberNames["h"] - 1;
                numberNames["r"] = numberNames["r"] - 1;
                numberNames["e"] = numberNames["e"] - 2;

                tforThree  = tforThree  - 1;
                hforThree  = hforThree  - 1;
                rforeThree = rforeThree - 1;
                eforeThree = eforeThree - 2;
            }



            //For Four

            int fforFour = numberNames.ContainsKey("f") ? numberNames["f"]:0;
            int oforFour = numberNames.ContainsKey("o") ? numberNames["o"]:0;
            int uforeFour = numberNames.ContainsKey("u") ? numberNames["u"]:0;
            int rforeFour = numberNames.ContainsKey("r") ? numberNames["r"]:0;

            while (fforFour > 0 && oforFour > 0 && uforeFour > 0 && rforeFour > 0)
            {
                fourCount = fourCount + 1;
                numberNames["f"] =numberNames["f"] - 1;
                numberNames["o"] =numberNames["o"] - 1;
                numberNames["u"] =numberNames["u"] - 1;
                numberNames["r"] = numberNames["r"] - 1;

               fforFour = fforFour -1;
               oforFour = oforFour -1;
               uforeFour =uforeFour- 1;
                rforeFour =rforeFour - 1;
            }


            //For Five

            int fforFive = numberNames.ContainsKey("f") ? numberNames["f"]:0;
            int iforFive = numberNames.ContainsKey("i") ? numberNames["i"]:0;
            int vforFive = numberNames.ContainsKey("v") ? numberNames["v"]:0;
            int eforFive = numberNames.ContainsKey("e") ? numberNames["e"]:0;

            while (fforFive > 0 && iforFive > 0 && vforFive > 0 && eforFive > 0)
            {
                fiveCount = fiveCount + 1;
                numberNames["f"] = numberNames["f"] - 1;
                numberNames["i"] = numberNames["i"] - 1;
                numberNames["v"] = numberNames["v"] - 1;
                numberNames["e"] = numberNames["e"] - 1;

                fforFive= fforFive- 1;
                iforFive= iforFive- 1;
                vforFive =vforFive - 1;
                eforFive = eforFive - 1;
            }


            //For Six

            int sforSix = numberNames.ContainsKey("s") ? numberNames["s"]:0;
            int iforSix = numberNames.ContainsKey("i") ? numberNames["i"]:0;
            int xforSix = numberNames.ContainsKey("x") ? numberNames["x"]:0;

            while (sforSix > 0 && iforSix > 0 && xforSix > 0)
            {
                sixCount = sixCount + 1;
                numberNames["s"] = numberNames["s"] - 1;
                numberNames["i"] = numberNames["i"] - 1;
                numberNames["x"] = numberNames["x"] - 1;

                sforSix= sforSix-1;
                iforSix= iforSix-1;
                xforSix = xforSix - 1;
            }

            //For Seven

            int sforSeven = numberNames.ContainsKey("s") ? numberNames["s"] : 0;
            int eforSeven = numberNames.ContainsKey("e") ? numberNames["e"] : 0;
            int vforSeven = numberNames.ContainsKey("v") ? numberNames["v"] : 0;

            while (sforSeven > 0 && eforSeven > 0 && vforSeven > 0)
            {
                sevenCount = sevenCount + 1;
                numberNames["s"] = numberNames["s"] - 1;
                numberNames["e"] = numberNames["e"] - 2;
                numberNames["v"] = numberNames["v"] - 1;

                sforSeven = sforSeven - 1;
                eforSeven = eforSeven - 2;
                vforSeven = vforSeven - 1;

            }

            //For Eight

            int eforEight = numberNames.ContainsKey("e") ? numberNames["e"] : 0;
            int iforEight = numberNames.ContainsKey("i") ? numberNames["i"] : 0;
            int gforEight = numberNames.ContainsKey("g") ? numberNames["g"] : 0;
            int hforEight = numberNames.ContainsKey("h") ? numberNames["h"] : 0;
            int tforEight = numberNames.ContainsKey("t") ? numberNames["t"] : 0;

            if (eforEight > 0 && iforEight > 0 && gforEight > 0 && hforEight > 0 && tforEight > 0)
            {
                sevenCount = sevenCount + 1;
                numberNames["e"] = numberNames["e"] - 1;
                numberNames["i"] = numberNames["i"] - 1;
                numberNames["g"] = numberNames["g"] - 1;
                numberNames["h"] = numberNames["h"] - 1;
                numberNames["t"] = numberNames["t"] - 1;

                 eforEight=  eforEight-1;
                 iforEight=  iforEight-1;
                 gforEight=  gforEight-1;
                 hforEight=  hforEight-1;
                 tforEight = tforEight - 1;

            }


            //For Nine

            int nforNine = numberNames.ContainsKey("n") ? numberNames["n"] : 0;
            int iforNine = numberNames.ContainsKey("i") ? numberNames["i"] : 0;
            int eforNine = numberNames.ContainsKey("e") ? numberNames["e"] : 0;

            if (nforNine > 0 && iforNine > 0 && eforNine > 0)
            {
                sevenCount = sevenCount + 1;
                numberNames["n"] = numberNames["n"] - 2;
                numberNames["i"] = numberNames["i"] - 1;
                numberNames["e"] = numberNames["e"] - 1;

                 nforNine = nforNine - 2;
                 iforNine = iforNine - 1;
                 eforNine = eforNine - 1;

            }
            if (oneCount > 0)
            {
                for(int k =0; k < oneCount; k++)
                {
                    output = output + "1";
                }
            }
            if (twoCount > 0)
            {
                for (int k = 0; k < twoCount; k++)
                {
                    output = output + "2";
                }
               
            }
            if (threeCount > 0)
            {
                for (int k = 0; k < threeCount; k++)
                {
                    output = output + "3";
                }
            }
            if (fourCount > 0)
            {
                for (int k = 0; k < fourCount; k++)
                {
                    output = output + "4";
                }
            }

            if (fiveCount > 0)
            {
                for (int k = 0; k < fiveCount; k++)
                {
                    output = output + "5";
                }
            }
            if (sixCount > 0)
            {
                for (int k = 0; k < sixCount; k++)
                {
                    output = output + "6";
                }
            }
            if (sevenCount > 0)
            {
                for (int k = 0; k < sevenCount; k++)
                {
                    output = output + "7";
                }
            }
            if (eightCount > 0)
            {
                for (int k = 0; k < eightCount; k++)
                {
                    output = output + "8";
                }
            }
            if (nineCount > 0)
            {
                for (int k = 0; k < nineCount; k++)
                {
                    output = output + "9";
                }
            }

            Console.WriteLine(output);
           
        }
    }
}
