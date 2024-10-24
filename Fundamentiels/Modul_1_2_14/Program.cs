using System;
using System.Diagnostics;
using System.Xml.Linq;
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
            decimal scores_average = 0;
            decimal scores_average_without_extra_credit = 0;
            decimal scores_average_without_extra_credit_without_decimal = 0;
            decimal scores_extra_credit_point = 0;
            string grade = "";
            string overall_grade = "";
            decimal normal_num_assignments = 5;
            decimal scores_sum = 0;




            decimal scores_sum_normal_num_assignments = 0;

            foreach (decimal score in scores.Take((int)normal_num_assignments))
            {
                scores_sum_normal_num_assignments += score;
            }
            decimal scores_sum_rest = 0;
            decimal scores_rest_count = 0;

            foreach (decimal score in scores.Skip((int)normal_num_assignments))
            {
                scores_rest_count++;
                scores_sum_rest += score;
            }

            scores_sum = scores_sum_normal_num_assignments + (scores_sum_rest / 10);

            scores_extra_credit_point = Math.Round((scores_sum_rest / 10) / normal_num_assignments, 2);


            scores_average_without_extra_credit = Math.Round(scores_sum_normal_num_assignments / normal_num_assignments, 1);
            scores_average_without_extra_credit_without_decimal = Math.Round(scores_sum_rest / scores_rest_count, 0);

            scores_average = Math.Round((scores_sum_normal_num_assignments / normal_num_assignments) + ((scores_sum_rest / 10) / normal_num_assignments), 2);

            overall_grade = scores_average + "\t" + GetGradeLetter(scores_average);

            grade = scores_average_without_extra_credit + "\t\t" + overall_grade + "\t\t" + scores_average_without_extra_credit_without_decimal + " (" + scores_extra_credit_point + " pts)";
            return grade;
        }

        static void Main(string[] args)
        {
            string[] names = { "Sophia", "Andrew", "Emma", "Logan" };
            Console.Clear();

            Console.WriteLine("\n" + "Student" + "\t\t" + "Exam Score" + "\t" + "Overall Grade" + "\t\t" + "Extra Credit" + "\n");
            foreach (string name in names)
            {
                decimal[] scores;

                if (name == "Sophia")
                {
                    scores = new decimal[] { 90, 86, 87, 98, 100, 94, 90 };
                }
                else if (name == "Andrew")
                {
                    scores = new decimal[] { 92, 89, 81, 96, 90, 89 };
                }
                else if (name == "Emma")
                {
                    scores = new decimal[] { 90, 85, 87, 98, 68, 89, 89, 89 };
                }
                else // Logan
                {
                    scores = new decimal[] { 90, 95, 87, 88, 96, 96 };
                }


                Console.WriteLine(name + "\t\t" + Calculate_grade(scores));
            }
            Console.WriteLine("\n");
        }
    }
}
