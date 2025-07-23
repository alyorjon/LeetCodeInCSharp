using System;
using System.Collections.Generic;
namespace LeetCodeInCSharp.Learns
{
	class Classes
{
    public static void Run()
    {
        Console.WriteLine("C# CLASS MASALALARI - BASIC LEVEL");
        Console.WriteLine(new string('=', 50));
        
        // Problem 1: Oddiy class yaratish
        Problem1_SimpleClass();
        
        // Problem 2: Constructor bilan ishlash
        Problem2_Constructor();
        
        // Problem 3: Method'lar yaratish
        Problem3_Methods();
        
        // Problem 4: Static vs Instance
        Problem4_StaticInstance();
        
        // Problem 5: Encapsulation
        Problem5_Encapsulation();
        
        // Problem 6: Object'lar bilan ishlash
        Problem6_Objects();
        
        // Problem 7: ToString override
        Problem7_ToString();
        
        // Problem 8: Multiple constructor'lar
        Problem8_MultipleConstructors();
        
        // Problem 9: Class array'i
        Problem9_ClassArray();
        
        // Problem 10: Basic inheritance
        Problem10_BasicInheritance();
    }
    
    #region Problem 1: Oddiy class yaratish
    
    static void Problem1_SimpleClass()
    {
        Console.WriteLine("\n=== Problem 1: Oddiy Class Yaratish ===");
        Console.WriteLine("Masala: Student ma'lumotlarini saqlash uchun oddiy class yarating");
        
        Console.WriteLine("\nYECHIM:");
        
        // Student object yaratish
        Student student1 = new Student();
        student1.Name = "Ali Valiyev";
        student1.Age = 20;
        student1.University = "TATU";
        
        // Ma'lumotlarni chiqarish
        Console.WriteLine($"Talaba: {student1.Name}");
        Console.WriteLine($"Yoshi: {student1.Age}");
        Console.WriteLine($"Universitet: {student1.University}");
        
        // Ikkinchi student
        Student student2 = new Student();
        student2.Name = "Maryam Karimova";
        student2.Age = 19;
        student2.University = "TUIT";
        
        Console.WriteLine($"\nIkkinchi talaba: {student2.Name}, {student2.Age} yosh, {student2.University}");
    }
    
    #endregion
    
    #region Problem 2: Constructor bilan ishlash
    
    static void Problem2_Constructor()
    {
        Console.WriteLine("\n=== Problem 2: Constructor bilan ishlash ===");
        Console.WriteLine("Masala: Car class yaratib, constructor orqali qiymat berish");
        
        Console.WriteLine("\nYECHIM:");
        
        // Constructor bilan car yaratish
        Car car1 = new Car("Toyota", "Camry", 2020);
        Console.WriteLine($"Mashina 1: {car1.Brand} {car1.Model} ({car1.Year})");
        
        Car car2 = new Car("BMW", "X5", 2022);
        Console.WriteLine($"Mashina 2: {car2.Brand} {car2.Model} ({car2.Year})");
        
        // Default constructor
        Car car3 = new Car();
        Console.WriteLine($"Default mashina: {car3.Brand} {car3.Model} ({car3.Year})");
    }
    
    #endregion
    
    #region Problem 3: Method'lar yaratish
    
    static void Problem3_Methods()
    {
        Console.WriteLine("\n=== Problem 3: Method'lar yaratish ===");
        Console.WriteLine("Masala: Calculator class yaratib, asosiy amallarni bajaring");
        
        Console.WriteLine("\nYECHIM:");
        
        Calculator calc = new Calculator();
        
        double a = 10, b = 5;
        Console.WriteLine($"Sonlar: a = {a}, b = {b}");
        Console.WriteLine($"Qo'shish: {calc.Add(a, b)}");
        Console.WriteLine($"Ayirish: {calc.Subtract(a, b)}");
        Console.WriteLine($"Ko'paytirish: {calc.Multiply(a, b)}");
        Console.WriteLine($"Bo'lish: {calc.Divide(a, b)}");
        
        // 0 ga bo'lish
        Console.WriteLine($"0 ga bo'lish: {calc.Divide(a, 0)}");
    }
    
    #endregion
    
    #region Problem 4: Static vs Instance
    
    static void Problem4_StaticInstance()
    {
        Console.WriteLine("\n=== Problem 4: Static vs Instance ===");
        Console.WriteLine("Masala: Bank account class'ida static va instance member'larni ko'rsating");
        
        Console.WriteLine("\nYECHIM:");
        
        // Static property
        Console.WriteLine($"Bank nomi: {BankAccount.BankName}");
        Console.WriteLine($"Jami account'lar: {BankAccount.TotalAccounts}");
        
        // Instance'lar yaratish
        BankAccount account1 = new BankAccount("Ali Valiyev", 1000);
        BankAccount account2 = new BankAccount("Maryam Karimova", 1500);
        
        Console.WriteLine($"\nAccount 1: {account1.AccountHolder} - ${account1.Balance}");
        Console.WriteLine($"Account 2: {account2.AccountHolder} - ${account2.Balance}");
        
        Console.WriteLine($"Jami account'lar: {BankAccount.TotalAccounts}");
        
        // Static method
        double interestRate = BankAccount.GetInterestRate();
        Console.WriteLine($"Foiz stavkasi: {interestRate}%");
    }
    
    #endregion
    
    #region Problem 5: Encapsulation
    
    static void Problem5_Encapsulation()
    {
        Console.WriteLine("\n=== Problem 5: Encapsulation ===");
        Console.WriteLine("Masala: Person class'ida private field'lar va public property'lar ishlatish");
        
        Console.WriteLine("\nYECHIM:");
        
        Person person = new Person();
        
        // Property orqali qiymat berish
        person.Name = "John Doe";
        person.Age = 25;
        person.Email = "john@example.com";
        
        Console.WriteLine($"Ism: {person.Name}");
        Console.WriteLine($"Yosh: {person.Age}");
        Console.WriteLine($"Email: {person.Email}");
        
        // Validatsiya test
        person.Age = -5;  // Bu xato qiymat
        Console.WriteLine($"Noto'g'ri yosh kiritilgandan keyin: {person.Age}");
        
        person.Email = "invalid-email";  // Noto'g'ri email
        Console.WriteLine($"Noto'g'ri email kiritilgandan keyin: {person.Email}");
        
        // Personal info (private method orqali)
        person.DisplayPersonalInfo();
    }
    
    #endregion
    
    #region Problem 6: Object'lar bilan ishlash
    
    static void Problem6_Objects()
    {
        Console.WriteLine("\n=== Problem 6: Object'lar bilan ishlash ===");
        Console.WriteLine("Masala: Book class yaratib, kutubxona tizimini simulyatsiya qiling");
        
        Console.WriteLine("\nYECHIM:");
        
        // Kitoblar yaratish
        Book book1 = new Book("C# Dasturlash", "John Smith", 2023, 500);
        Book book2 = new Book("Python Basics", "Jane Doe", 2022, 300);
        Book book3 = new Book("JavaScript Guide", "Mike Wilson", 2024, 400);
        
        // Kitob ma'lumotlarini ko'rsatish
        Console.WriteLine("Kutubxona kitoblari:");
        Console.WriteLine($"1. {book1.GetBookInfo()}");
        Console.WriteLine($"2. {book2.GetBookInfo()}");
        Console.WriteLine($"3. {book3.GetBookInfo()}");
        
        // Kitobni ijaraga berish
        Console.WriteLine("\nIjara jarayoni:");
        book1.BorrowBook("Ali Valiyev");
        book1.BorrowBook("Maryam Karimova"); // Bu xato bo'lishi kerak
        
        book2.BorrowBook("Olim Karimov");
        
        // Kitobni qaytarish
        book1.ReturnBook();
        book1.BorrowBook("Maryam Karimova"); // Endi ishlashi kerak
    }
    
    #endregion
    
    #region Problem 7: ToString override
    
    static void Problem7_ToString()
    {
        Console.WriteLine("\n=== Problem 7: ToString Override ===");
        Console.WriteLine("Masala: Product class'ida ToString method'ini override qiling");
        
        Console.WriteLine("\nYECHIM:");
        
        Product product1 = new Product(1, "Laptop", 1200.99m, 10);
        Product product2 = new Product(2, "Mouse", 25.50m, 100);
        Product product3 = new Product(3, "Keyboard", 85.00m, 50);
        
        Console.WriteLine("Mahsulotlar ro'yxati:");
        Console.WriteLine(product1); // ToString avtomatik chaqiriladi
        Console.WriteLine(product2);
        Console.WriteLine(product3);
        
        // Array ichida ToString
        Product[] products = { product1, product2, product3 };
        Console.WriteLine("\nArray ko'rinishida:");
        foreach (Product product in products)
        {
            Console.WriteLine($"- {product}");
        }
    }
    
    #endregion
    
    #region Problem 8: Multiple Constructor'lar
    
    static void Problem8_MultipleConstructors()
    {
        Console.WriteLine("\n=== Problem 8: Multiple Constructor'lar ===");
        Console.WriteLine("Masala: Employee class'ida turli constructor'lar yarating");
        
        Console.WriteLine("\nYECHIM:");
        
        // Turli constructor'lardan foydalanish
        Employee emp1 = new Employee(); // Default
        Console.WriteLine($"Employee 1: {emp1.GetEmployeeInfo()}");
        
        Employee emp2 = new Employee("John Doe"); // Faqat ism
        Console.WriteLine($"Employee 2: {emp2.GetEmployeeInfo()}");
        
        Employee emp3 = new Employee("Jane Smith", "Developer"); // Ism va lavozim
        Console.WriteLine($"Employee 3: {emp3.GetEmployeeInfo()}");
        
        Employee emp4 = new Employee("Mike Johnson", "Manager", 75000); // To'liq
        Console.WriteLine($"Employee 4: {emp4.GetEmployeeInfo()}");
        
        // Salary o'zgartirish
        emp4.GiveRaise(5000);
        Console.WriteLine($"Raise'dan keyin Employee 4: {emp4.GetEmployeeInfo()}");
    }
    
    #endregion
    
    #region Problem 9: Class Array'i
    
    static void Problem9_ClassArray()
    {
        Console.WriteLine("\n=== Problem 9: Class Array'i ===");
        Console.WriteLine("Masala: Grade class yaratib, student baholarini boshqaring");
        
        Console.WriteLine("\nYECHIM:");
        
        // Student'lar yaratish
        Grade[] grades = new Grade[4];
        grades[0] = new Grade("Ali Valiyev", "Mathematics", 95);
        grades[1] = new Grade("Maryam Karimova", "Physics", 88);
        grades[2] = new Grade("Olim Karimov", "Chemistry", 92);
        grades[3] = new Grade("Nigora Tosheva", "Biology", 97);
        
        Console.WriteLine("Student baholari:");
        foreach (Grade grade in grades)
        {
            Console.WriteLine(grade);
        }
        
        // Statistika
        double totalScore = 0;
        Grade bestGrade = grades[0];
        Grade worstGrade = grades[0];
        
        foreach (Grade grade in grades)
        {
            totalScore += grade.Score;
            
            if (grade.Score > bestGrade.Score)
                bestGrade = grade;
            
            if (grade.Score < worstGrade.Score)
                worstGrade = grade;
        }
        
        double averageScore = totalScore / grades.Length;
        
        Console.WriteLine($"\nStatistika:");
        Console.WriteLine($"O'rtacha ball: {averageScore:F2}");
        Console.WriteLine($"Eng yuqori ball: {bestGrade.StudentName} - {bestGrade.Score}");
        Console.WriteLine($"Eng past ball: {worstGrade.StudentName} - {worstGrade.Score}");
        
        // A grade olganlar
        Console.WriteLine("\nA grade olganlar (90+):");
        foreach (Grade grade in grades)
        {
            if (grade.Score >= 90)
            {
                Console.WriteLine($"- {grade.StudentName}: {grade.Score}");
            }
        }
    }
    
    #endregion
    
    #region Problem 10: Basic Inheritance
    
    static void Problem10_BasicInheritance()
    {
        Console.WriteLine("\n=== Problem 10: Basic Inheritance ===");
        Console.WriteLine("Masala: Animal base class va Dog derived class yarating");
        
        Console.WriteLine("\nYECHIM:");
        
        // Base class
        Animal animal1 = new Animal("Generic Animal", 5);
        Console.WriteLine($"Animal: {animal1.Name}, {animal1.Age} yosh");
        animal1.MakeSound();
        animal1.Sleep();
        
        Console.WriteLine();
        
        // Derived class
        Dog dog1 = new Dog("Rex", 3, "German Shepherd");
        Console.WriteLine($"Dog: {dog1.Name}, {dog1.Age} yosh, {dog1.Breed} zoti");
        dog1.MakeSound(); // Override qilingan method
        dog1.Sleep(); // Base class method
        dog1.Fetch(); // Dog class'ining o'ziga xos method
        
        Console.WriteLine();
        
        // Yana bir dog
        Dog dog2 = new Dog("Buddy", 2, "Golden Retriever");
        Console.WriteLine($"Dog: {dog2.Name}, {dog2.Age} yosh, {dog2.Breed} zoti");
        dog2.MakeSound();
        dog2.Fetch();
        
        // Polymorphism (basic)
        Console.WriteLine("\nPolymorphism misoli:");
        Animal[] animals = { animal1, dog1, dog2 };
        
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"{animal.Name} says:");
            animal.MakeSound(); // Har biri o'zining method'ini chaqiradi
        }
    }
    
    #endregion
}

#region Class Definitions

// Problem 1: Student class
public class Student
{
    public string Name;
    public int Age;
    public string University;
}

// Problem 2: Car class
public class Car
{
    public string Brand;
    public string Model;
    public int Year;
    
    // Constructor with parameters
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }
    
    // Default constructor
    public Car()
    {
        Brand = "Unknown";
        Model = "Unknown";
        Year = 2000;
    }
}

// Problem 3: Calculator class
public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Xato: 0 ga bo'lib bo'lmaydi!");
            return 0;
        }
        return a / b;
    }
}

// Problem 4: BankAccount class
public class BankAccount
{
    // Static members
    public static string BankName = "Universal Bank";
    public static int TotalAccounts = 0;
    
    // Instance members
    public string AccountHolder;
    public double Balance;
    
    public BankAccount(string accountHolder, double initialBalance)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
        TotalAccounts++; // Static counter
    }
    
    // Static method
    public static double GetInterestRate()
    {
        return 2.5; // 2.5%
    }
}

// Problem 5: Person class (Encapsulation)
public class Person
{
    // Private fields
    private string _name;
    private int _age;
    private string _email;
    
    // Public properties with validation
    public string Name
    {
        get { return _name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                _name = value;
            else
                Console.WriteLine("Ism bo'sh bo'lishi mumkin emas!");
        }
    }
    
    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 0 && value <= 120)
                _age = value;
            else
                Console.WriteLine("Yosh 0 dan 120 gacha bo'lishi kerak!");
        }
    }
    
    public string Email
    {
        get { return _email; }
        set
        {
            if (value.Contains("@"))
                _email = value;
            else
                Console.WriteLine("Email noto'g'ri formatda!");
        }
    }
    
    // Private method
    private string GetFullInfo()
    {
        return $"{_name} ({_age} yosh) - {_email}";
    }
    
    // Public method that uses private method
    public void DisplayPersonalInfo()
    {
        Console.WriteLine($"Shaxsiy ma'lumot: {GetFullInfo()}");
    }
}

// Problem 6: Book class
public class Book
{
    public string Title;
    public string Author;
    public int Year;
    public int Pages;
    public bool IsAvailable;
    public string BorrowedBy;
    
    public Book(string title, string author, int year, int pages)
    {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
        IsAvailable = true;
        BorrowedBy = "";
    }
    
    public string GetBookInfo()
    {
        string status = IsAvailable ? "Mavjud" : $"Ijarada ({BorrowedBy})";
        return $"'{Title}' - {Author} ({Year}) - {Pages} bet - {status}";
    }
    
    public void BorrowBook(string borrower)
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            BorrowedBy = borrower;
            Console.WriteLine($"'{Title}' kitobi {borrower}ga berildi");
        }
        else
        {
            Console.WriteLine($"'{Title}' kitobi allaqachon {BorrowedBy}da");
        }
    }
    
    public void ReturnBook()
    {
        if (!IsAvailable)
        {
            Console.WriteLine($"'{Title}' kitobi {BorrowedBy}dan qaytarildi");
            IsAvailable = true;
            BorrowedBy = "";
        }
        else
        {
            Console.WriteLine($"'{Title}' kitobi allaqachon mavjud");
        }
    }
}

// Problem 7: Product class
public class Product
{
    public int Id;
    public string Name;
    public decimal Price;
    public int Stock;
    
    public Product(int id, string name, decimal price, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }
    
    // ToString method override
    public override string ToString()
    {
        return $"[{Id}] {Name} - ${Price} (Stock: {Stock})";
    }
}

// Problem 8: Employee class
public class Employee
{
    public string Name;
    public string Position;
    public decimal Salary;
    
    // Default constructor
    public Employee()
    {
        Name = "Unknown";
        Position = "Employee";
        Salary = 30000;
    }
    
    // Constructor with name only
    public Employee(string name)
    {
        Name = name;
        Position = "Employee";
        Salary = 30000;
    }
    
    // Constructor with name and position
    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
        Salary = 35000;
    }
    
    // Full constructor
    public Employee(string name, string position, decimal salary)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }
    
    public string GetEmployeeInfo()
    {
        return $"{Name} - {Position} - ${Salary}";
    }
    
    public void GiveRaise(decimal amount)
    {
        Salary += amount;
        Console.WriteLine($"{Name}ga ${amount} ish haqi oshirildi");
    }
}

// Problem 9: Grade class
public class Grade
{
    public string StudentName;
    public string Subject;
    public int Score;
    
    public Grade(string studentName, string subject, int score)
    {
        StudentName = studentName;
        Subject = subject;
        Score = score;
    }
    
    public override string ToString()
    {
        string gradeLevel = GetGradeLevel();
        return $"{StudentName} - {Subject}: {Score} ({gradeLevel})";
    }
    
    private string GetGradeLevel()
    {
        if (Score >= 90) return "A";
        else if (Score >= 80) return "B";
        else if (Score >= 70) return "C";
        else if (Score >= 60) return "D";
        else return "F";
    }
}

// Problem 10: Animal classes (Inheritance)
public class Animal
{
    public string Name;
    public int Age;
    
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} ovoz chiqaradi");
    }
    
    public void Sleep()
    {
        Console.WriteLine($"{Name} uxlamoqda");
    }
}

public class Dog : Animal
{
    public string Breed;
    
    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }
    
    // Override base class method
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} vov-vov deydi!");
    }
    
    // Dog class'ining o'ziga xos method
    public void Fetch()
    {
        Console.WriteLine($"{Name} to'pni olib keladi");
    }
}

#endregion

/* 
MASALALAR SUMMARY:

1. ✅ Oddiy class - Student ma'lumotlari
2. ✅ Constructor - Car class 
3. ✅ Method'lar - Calculator amallar
4. ✅ Static vs Instance - BankAccount
5. ✅ Encapsulation - Person validation
6. ✅ Object'lar - Book kutubxona
7. ✅ ToString override - Product
8. ✅ Multiple constructor - Employee
9. ✅ Class array - Grade tizimi
10. ✅ Basic inheritance - Animal/Dog

Har bir masala:
- Real dunyo misollar
- To'liq ishlaydigan kod
- Test ma'lumotlari
- Tushuntirishlar

ASOSIY TUSHUNCHALAR:
- Class va Object
- Constructor'lar
- Method'lar
- Property'lar
- Encapsulation
- Static members
- Inheritance (basic)
- Method override
- ToString() method
*/
}
