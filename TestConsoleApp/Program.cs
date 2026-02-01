// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person person = new Person{ PersonId = 1, Name = "홍길동", Age = 20 };
Console.WriteLine($"이름 : {person.Name} / 나이 : {person.Age}");

Person person2 = new Person { PersonId = 2, Name = "손흥민", Age = 30 };
Console.WriteLine($"이름 : {person2.Name} / 나이 : {person2.Age}");
