using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    class Activity2
{
    static void Main(string[] args)
    {
            string[] names = new string[5];
            names[0] = "Hell";
            string name1 = names[0];
            Console.WriteLine(name1);

        Student firstStudent = new Student();
        Student secondStudent = new Student();
        Student thirdStudent = new Student();

        Console.WriteLine("Enter marks of student #1");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter marks of student #1 in subject {0}, out of 50"
                              , i + 1);
            firstStudent.setMarks(
                    Int32.Parse(Console.ReadLine()), i);
        }

        Console.WriteLine("\nEnter marks of student #2");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter marks of student #2 in subject {0}, out of 50"
                              , i + 1);
            secondStudent.setMarks(
                    Int32.Parse(Console.ReadLine()), i);
        }

        Console.WriteLine("\nEnter marks of student #3");
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter marks of student #3 in subject {0}, out of 50"
                              , i + 1);
            thirdStudent.setMarks(
                    Int32.Parse(Console.ReadLine()), i);
        }

        firstStudent.calculatePercentage();
        secondStudent.calculatePercentage();
        thirdStudent.calculatePercentage();

        Console.WriteLine("\nStudent #1 Report:");
        Console.WriteLine("Grade: {0}"
                          , firstStudent.getGrades());
        Console.WriteLine("Percentage: {0}%", firstStudent.getPercentage());
        Console.WriteLine("Maximum marks in Subject #{0}: {1}"
                          , firstStudent.getMaxMarks()[1], firstStudent.getMaxMarks()[0]);
        Console.WriteLine("Minimum marks in Subject #{0}: {1}"
                          , firstStudent.getMinMarks()[1], firstStudent.getMinMarks()[0]);
        Console.WriteLine("Average marks: {0}", firstStudent.getAvgMarks());

        Console.WriteLine("\nStudent #2 Report:");
        Console.WriteLine("Grade: {0}", secondStudent.getGrades());
        Console.WriteLine("Percentage: {0}%", secondStudent.getPercentage());
        Console.WriteLine("Maximum marks in Subject #{0}: {1}"
                          , secondStudent.getMaxMarks()[1], secondStudent.getMaxMarks()[0]);
        Console.WriteLine("Minimum marks in Subject #{0}: {1}"
                          , secondStudent.getMinMarks()[1], secondStudent.getMinMarks()[0]);
        Console.WriteLine("Average marks: {0}", secondStudent.getAvgMarks());

        Console.WriteLine("\nStudent #3 Report:");
        Console.WriteLine("Grade: {0}", thirdStudent.getGrades());
        Console.WriteLine("Percentage: {0}%", thirdStudent.getPercentage());
        Console.WriteLine("Maximum marks in Subject #{0}: {1}"
                          , thirdStudent.getMaxMarks()[1], thirdStudent.getMaxMarks()[0]);
        Console.WriteLine("Minimum marks in Subject #{0}: {1}"
                          ,thirdStudent.getMinMarks()[1], thirdStudent.getMinMarks()[0]);
        Console.WriteLine("Average marks: {0}", thirdStudent.getAvgMarks());
        
        Console.WriteLine();

        if (firstStudent.getPercentage() > secondStudent.getPercentage()){

            if (firstStudent.getPercentage() > thirdStudent.getPercentage()){
                Console.WriteLine("Student #1 scored Maximum: {0}%"
                                  , firstStudent.getPercentage());
            }else{
                Console.WriteLine("Student #3 scored Maximum: {0}%"
                                  , thirdStudent.getPercentage());
            }
        }else{
            if (secondStudent.getPercentage() > thirdStudent.getPercentage())
            {
                Console.WriteLine("Student #2 scored Maximum: {0}%"
                                  , secondStudent.getPercentage());
            }else{
                Console.WriteLine("Student #3 scored Maximum: {0}%"
                                  , thirdStudent.getPercentage());
            }

        }



        if (firstStudent.getPercentage() < secondStudent.getPercentage()){

            if (firstStudent.getPercentage() < thirdStudent.getPercentage()){
                Console.WriteLine("Student #1 scored Minimum: {0}%"
                                  , firstStudent.getPercentage());
            }else{
                Console.WriteLine("Student #3 scored Minimum: {0}%"
                                  , thirdStudent.getPercentage());
            }

        }else{

            if (secondStudent.getPercentage() < thirdStudent.getPercentage()){
                Console.WriteLine("Student #2 scored Minimum: {0}%"
                                  , secondStudent.getPercentage());
            }else{
                Console.WriteLine("Student #3 scored Minimum: {0}%"
                                  , thirdStudent.getPercentage());
            }

        }

       
        Console.ReadKey();
             
    }
}

class Student
{
    private float[] subjectMarks;
    private float studentPercentage;
    private String studentGrade;
    public Student()
    {
        subjectMarks = new float[5];
    }

    public float[] getmarks()
    {
        return subjectMarks;
    }

    public void setMarks(int marks, int index)
    {
        this.subjectMarks[index] = marks;

    }

    public void calculatePercentage()
    {
        studentPercentage = ((subjectMarks[0] + subjectMarks[1] + subjectMarks[2]
                              + subjectMarks[3] + subjectMarks[4]) / (50 * 5)) * 100;

        if (studentPercentage < 50)
        {
                studentGrade = "F";
        }
        else if (studentPercentage <= 60)
        {
                studentGrade = "D";
        }
        else if (studentPercentage <= 70)
        {
                studentGrade = "C";
        }
        else if (studentPercentage <= 80)
        {
                studentGrade = "B";
        }
        else if (studentPercentage <= 90)
        {
                studentGrade = "A";
        }
        else if (studentPercentage <= 100)
        {
                studentGrade = "A+";
        }
    }

        public float getPercentage() { return studentPercentage; }
        public String getGrades() { return studentGrade; }

        public int[] getMaxMarks(){
            int[] returnBlock = new int[2];
            returnBlock[0] = (int)subjectMarks.Max();
            returnBlock[1] = Array.IndexOf(subjectMarks, subjectMarks.Max()) + 1;

            return returnBlock;

        }

        public int[] getMinMarks()
        {
            int[] returnBlock = new int[2];
            returnBlock[0] = (int)subjectMarks.Min();
            returnBlock[1] = Array.IndexOf(subjectMarks, subjectMarks.Min()) + 1;
            return returnBlock;

        }

        public int getAvgMarks()
        {
            return (int)subjectMarks.Average();

        }


    }
}