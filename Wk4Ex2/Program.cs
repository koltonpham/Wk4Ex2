using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex2
{
    internal class Program
    {
        public static double calculateAssignments()
        {
            //declarations
            double retVal = 0;
            bool inputingData = true;
            double grade = 0;
            double total = 0;
            int count = 0;

            while (inputingData) //while loop to take grades
            {
                Console.WriteLine("Please enter your grades for assignments. Enter -1 to finish"); //ask user for grades
                grade = Convert.ToDouble(Console.ReadLine());                                      //convert grades to double for calculation

                if (grade == -1) //if user enters a -1 to quit 
                {
                    inputingData = false; //set to false to break out of loop
                }
                else
                {
                    total += grade; //store the total grade
                    count++;        //increment count for each grade entered
                }
            }
            retVal = total / count; //calculate final grade
            return retVal; //return final value
        }

        public static double calculateMidterms()
        {
            //declarations
            double retVal = 0;
            bool inputingData = true;
            double grade = 0;
            double total = 0;
            int count = 0;

            while (inputingData) //while loop to take grades
            {
                Console.WriteLine("Please enter your grades for midterms. Enter -1 to finish"); //ask user for grades
                grade = Convert.ToDouble(Console.ReadLine());                                      //convert grades to double for calculation

                if (grade == -1) //if user enters a -1 to quit 
                {
                    inputingData = false; //set to false to break out of loop
                }
                else
                {
                    total += grade; //store the total grade
                    count++;        //increment count for each grade entered
                }
            }
            retVal = total / count; //calculate final grade
            return retVal; //return final value
        }

        public static double calculateFinals()
        {
            //declarations
            double retVal = 0;
            bool inputingData = true;
            double grade = 0;
            double total = 0;
            int count = 0;

            while (inputingData) //while loop to take grades
            {
                Console.WriteLine("Please enter your grades for finals. Enter -1 to finish"); //ask user for grades
                grade = Convert.ToDouble(Console.ReadLine());                                      //convert grades to double for calculation

                if (grade == -1) //if user enters a -1 to quit 
                {
                    inputingData = false; //set to false to break out of loop
                }
                else
                {
                    total += grade; //store the total grade
                    count++;        //increment count for each grade entered
                }
            }
            retVal = total / count; //calculate final grade
            return retVal; //return final value
        }

        public static double calculateFinalGrade(double assignments, double midterm, double final)
        {
            //declaration
            double retVal = 0;
            double finalGrade = 0;

            finalGrade = ((assignments * 0.40) + (midterm * 0.30) + (final * 0.30)); //calculate finalgrade
            retVal = finalGrade; //assign final grade to return value

            return retVal; //return final grade to be used
        }
        static void Main(string[] args)
        {
            //declarations
            double assignments = 0;
            double midterm = 0;
            double final = 0;

            assignments = calculateAssignments(); //call method to get grade for assignments and store in var
            Console.WriteLine("Assignments average: " + assignments); //display assignments grade

            midterm = calculateMidterms(); //call method to get grade for midterms and store in var
            Console.WriteLine("Midterm average: " + midterm); //display assignments grade

            final = calculateFinals(); //call method to get grade for finals and store in var
            Console.WriteLine("Finals average: " + final); //display assignments grade

            Console.WriteLine("Your final grade is: " + calculateFinalGrade(assignments, midterm, final)); //call method to get final grade
        }
    }
}
