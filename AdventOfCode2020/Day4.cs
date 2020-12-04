using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AdventOfCode2020
{
    class Day4
    {
        public static void Part1()
        {
            string line;
            string passportline = "";
            int validpassports = 0;
            StreamReader file = new StreamReader("..\\..\\..\\Resources\\Day4.txt");
            while((line = file.ReadLine()) != null || line == null)
            {
                if(line == null || line.Trim() == "" )               
                {
                    Dictionary<string, bool> Cred = Credentials();
                    string[] passport = passportline.Split(' ');

                    foreach(string s in passport)
                    {
                        try
                        {
                            Cred[s.Split(':')[0]] = true;
                        }
                        catch { }
                    }

                    if(!Cred.ContainsValue(false))
                    {
                        validpassports++;
                    }

                    passportline = "";
                    if (line == null) { break; }
                    continue;
                }
                else
                {
                    passportline += " " + line;
                }
            }
            Console.WriteLine(validpassports);

            file.Close();
        }

        public static Dictionary<string, bool> Credentials()
        {
            Dictionary<string, bool> Credentials = new Dictionary<string, bool>();
            Credentials.Add("byr", false);
            Credentials.Add("iyr", false);
            Credentials.Add("eyr", false);
            Credentials.Add("hgt", false);
            Credentials.Add("hcl", false);
            Credentials.Add("ecl", false);
            Credentials.Add("pid", false);
            //Credentials.Add("cid", false);
            return Credentials;

        }
    }

}
