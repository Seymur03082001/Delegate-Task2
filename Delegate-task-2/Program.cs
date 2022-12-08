using Delegate_task_2.Models;
using System.Collections.Generic;

namespace Delegate_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exam = new List<Exam>();

            DateTime StartDate = new DateTime(2022,12,7,12,00,00);
            DateTime EndDate = new DateTime(2022,12,13,12,30,00);

            DateTime StartDate1 = new DateTime(2022, 12, 7, 15, 00, 00);
            DateTime EndDate1 = new DateTime(2022, 12, 13, 15, 30, 00);

            Exam student1 = new Exam("Seymur Ibrahimov", 50, "Geography", StartDate, EndDate);
            Exam student2 = new Exam("Ilham Quliyev", 50, "Kimya", StartDate, EndDate);
            exam.Add(student1);
            exam.Add(student2);

            Console.WriteLine("exam list");
            foreach (Exam item in exam.FindAll(exam => exam.Point > 50))
            {
                Console.WriteLine($"Student:{ item.Student} Point: {item.Point} Subject : {item.Subject} StartDate : {item.StartDate} EndDate :{item.EndDate}");
            }
           
            foreach(Exam item in exam.FindAll(exam=> (exam.EndDate.Day - exam.StartDate.Day)<7))
            {
                Console.WriteLine($"Student:{item.Student} Point: {item.Point} Subject : {item.Subject} StartDate : {item.StartDate} EndDate :{item.EndDate}");
            }
            foreach(Exam item in exam.FindAll(exam => (exam.StartDate.Day - exam.EndDate.Day) > 1))
            {
                Console.WriteLine($"Student:{item.Student} Point: {item.Point} Subject : {item.Subject} StartDate : {item.StartDate} EndDate :{item.EndDate}");
            }
        }
        
    }
}