using System;
using System.Collections.Generic;
using System.Linq;
using Orientacao.ContentContext;
using Orientacao.SubscriptionContext;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var articles = new List<Article>();
            // articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            // articles.Add(new Article("Artigo sobre C#", "C#"));
            // articles.Add(new Article("Artigo sobre .NET", ".net"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }

            // var courses = new List<Course>()
            // {
            //     new Course("Fundamentos OOP", "fundamentos-oop"),
            //     new Course("Fundamentos C#", "fundamentos-csharp"),
            //     new Course("Fundamentos .NET", "fundamentos-dotnet")
            // };

            // var career = new Career("Especialista .NET", "especialista-dotnet");

            // career.Items.Add(new CareerItem(2, "Aprenda .NET", "", courses.First()));
            // career.Items.Add(new CareerItem(1, "Comece por aqui", "", courses.Last()));

            // var careers = new List<Career>()
            // {
            //     career
            // };

            // foreach (var c in careers)
            // {
            //     Console.WriteLine(c.Title);

            //     foreach (var course in c.Items.OrderBy(x => x.Order))
            //     {
            //         foreach (var notification in course.Notifications)
            //             Console.WriteLine($"{notification.Property} - {notification.Message}");

            //         Console.WriteLine($"{course.Order} - {course.Title}");
            //     }
            // }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);

            student.Subscriptions.Add(payPalSubscription);

            Console.WriteLine(student.Subscriptions);
        }
    }
}