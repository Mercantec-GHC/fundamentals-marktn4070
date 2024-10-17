using System;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace MyApplication
{
    class Program
    {
        static string GetGradeLetter(decimal scores_average)
        {
            string grade_score = "";

            if (scores_average >= 97)
            {
                grade_score = "A+";
            }
            else if (scores_average >= 93)
            {
                grade_score = "A";
            }
            else if (scores_average >= 90)
            {
                grade_score = "A-";
            }
            else if (scores_average >= 87)
            {
                grade_score = "B+";
            }
            else if (scores_average >= 83)
            {
                grade_score = "B";
            }
            else if (scores_average >= 80)
            {
                grade_score = "B-";
            }
            else if (scores_average >= 77)
            {
                grade_score = "C+";
            }
            else if (scores_average >= 73)
            {
                grade_score = "C";
            }
            else if (scores_average >= 70)
            {
                grade_score = "C-";
            }
            else if (scores_average >= 67)
            {
                grade_score = "D+";
            }
            else if (scores_average >= 63)
            {
                grade_score = "D";
            }
            else if (scores_average >= 60)
            {
                grade_score = "D-";
            }
            else if (scores_average >= 0)
            {
                grade_score = "F";
            }
            return grade_score;
        }

        static string Calculate_grade(decimal[] scores)
        {
            decimal scores_sum = 0;
            decimal scores_Length = 0;
            decimal scores_average = 0;
            string grade = "";
            foreach (decimal score in scores)
            {
                scores_sum += score;
            }
            scores_Length = scores.Length;
            scores_average = Math.Round(scores_sum / scores_Length, 2);
            grade = scores_average + "\t" + GetGradeLetter(scores_average);
            return grade;
        }

        static void Main(string[] args)
        {
            string[] names = { "Sophia", "Andrew", "Emma", "Logan" };

            foreach (string name in names)
            {
                decimal[] scores;

                if (name == "Sophia")
                {
                    scores = new decimal[] { 90, 86, 87, 98, 100 };
                }
                else if (name == "Andrew")
                {
                    scores = new decimal[] { 92, 89, 81, 96, 90 };
                }
                else if (name == "Emma")
                {
                    scores = new decimal[] { 90, 85, 87, 98, 68 };
                }
                else // Logan
                {
                    scores = new decimal[] { 90, 95, 87, 88, 96 };
                }
                Console.WriteLine(name + "\t" + Calculate_grade(scores));
            }
        }
    }
}
