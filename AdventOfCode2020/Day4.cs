using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions; 

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

        public static void Part2()
        {
            string line;
            string passportline = "";
            int validpassports = 0;
            StreamReader file = new StreamReader("..\\..\\..\\Resources\\Day4.txt");
            while ((line = file.ReadLine()) != null || line == null)
            {
                if (line == null || line.Trim() == "")
                {
                    Dictionary<string, bool> Cred = Credentials();
                    string[] passport = passportline.Split(' ');

                    foreach (string s in passport)
                    {
                        try
                        {
                                var parameteres = s.Split(':')[1];
                                var method = s.Split(':')[0];
                                Cred[s.Split(':')[0]] = ValidateField(method, parameteres);
                        }
                        catch {}
                    }
                    if (!Cred.ContainsValue(false))
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
            return Credentials;
        }

        public static bool ValidateField(string method, string input)
        {
            switch (method)
            {
                case "byr": return byr(input);
                case "iyr": return iyr(input);
                case "eyr": return eyr(input);
                case "hgt": return hgt(input);
                case "hcl": return hcl(input);
                case "ecl": return ecl(input);
                case "pid": return pid(input);
                default: return true;
            }
        }

        public static bool byr(string input)
        {
            Regex regbyr = new Regex(@"^\b(19[2-9][0-9]|200[0-2])\b$");
            if(regbyr.IsMatch(input))
            {
                return true;
            }
            return false;
        }
        public static bool iyr(string input)
        {
            Regex regiyr = new Regex(@"^\b(201[0-9]|2020)\b$");
            if (regiyr.IsMatch(input))
            {
                return true;
            }
            return false;
        }
        public static bool eyr(string input)
        {
            Regex regeyr = new Regex(@"^\b(202[0-9]|2030)\b$");
            if (regeyr.IsMatch(input))
            {
                return true;
            }
            return false;
        }
        public static bool hgt(string input)
        {
            Regex reghgt = new Regex(@"^\b(1[5-8][0-9]cm|19[0-3]cm|59in|6[0-9]in|7[0-6]in)\b$");
            if (reghgt.IsMatch(input))
            {
                return true;
            }
            return false;
        }
        public static bool hcl(string input)
        {
            Regex reghcl = new Regex(@"^#[a-f0-9]{6}$");
            if (reghcl.IsMatch(input))
            {
                return true;
            }
            return false;
        }
        public static bool ecl(string input)
        {
            Regex reghcl = new Regex(@"^\b(amb|blu|brn|gry|grn|hzl|oth)\b$");
            if (reghcl.IsMatch(input))
            {
                return true;
            }
            return false;
        }
        public static bool pid(string input)
        {
            Regex reghcl = new Regex(@"^\b([0-9]{9})\b$");
            if (reghcl.IsMatch(input))
            {
                return true;
            }
            return false;
        }

    }

}
