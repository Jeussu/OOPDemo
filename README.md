# OOP
76. Objects Intro

Lập trình hướng đối tượng (OOP) là một mô hình lập trình tập trung vào việc thiết kế và cấu trúc mã xung quanh các đối tượng, là các thể hiện của các lớp. C# là ngôn ngữ lập trình hướng đối tượng hỗ trợ đầy đủ các nguyên tắc OOP. Dưới đây là các khái niệm chính về lập trình hướng đối tượng trong C#:

1. **Lớp và Đối tượng**:
    Một lớp là một kế hoạch chi tiết hoặc khuôn mẫu xác định cấu trúc và hành vi của các đối tượng. Một đối tượng là một thể hiện của một lớp. Trong C#, bạn định nghĩa các lớp bằng cách sử dụng từ khóa `class`. Các đối tượng được tạo bằng cách sử dụng từ khóa `new`.

   ```csharp
   class Car
{
    public string Model { get; set; }
    public int Year { get; set; }
}

Car myCar = new Car();
myCar.Model = "Toyota";
myCar.Year = 2022;
   ```
2. **Đóng gói**:
    Đóng gói là thực hành gói dữ liệu (thuộc tính) và phương thức (chức năng) hoạt động trên dữ liệu thành một đơn vị (lớp). Quyền truy cập vào các chi tiết bên trong của một đối tượng được kiểm soát thông qua các công cụ sửa đổi quyền truy cập (public, private, protected, internal) để đảm bảo tính toàn vẹn và bảo mật của dữ liệu.

3. **Thừa kế**:
    Kế thừa là một cơ chế cho phép một lớp kế thừa các thuộc tính và hành vi từ một lớp khác. Lớp được kế thừa từ đó được gọi là lớp cơ sở hoặc lớp cha và lớp kế thừa được gọi là lớp dẫn xuất hoặc lớp con. C# hỗ trợ kế thừa đơn, trong đó một lớp chỉ có thể kế thừa từ một lớp cơ sở.

4. **Đa hình**:
    Tính đa hình cho phép các đối tượng thuộc các lớp khác nhau được coi là đối tượng của một lớp cơ sở chung. Điều này đạt được thông qua ghi đè phương thức và giao diện. Tính đa hình cho phép hành vi động và gọi phương thức trong thời gian chạy.

5. **Trừu tượng**:
    Trừu tượng hóa liên quan đến việc xác định các thuộc tính và hành vi thiết yếu của một đối tượng trong khi ẩn các chi tiết không liên quan. Các lớp và giao diện trừu tượng được sử dụng để định nghĩa các trừu tượng trong C#.

6. **Các lớp trừu tượng**:
    Một lớp trừu tượng là một lớp không thể được khởi tạo trực tiếp và có thể chứa các phương thức trừu tượng (các phương thức không có phần thân). Nó phục vụ như một lớp cơ sở cho các lớp khác bắt nguồn từ đó.

7. **Giao diện**:
    Một giao diện xác định một hợp đồng mà các lớp phải tuân thủ. Nó chỉ định một tập hợp các phương thức mà các lớp triển khai phải cung cấp. Một lớp có thể thực hiện nhiều giao diện.

8. **Công cụ sửa đổi truy cập**:
    Công cụ sửa đổi truy cập kiểm soát khả năng hiển thị và khả năng truy cập của các lớp, thành viên (trường và phương thức) và thuộc tính. Các công cụ sửa đổi quyền truy cập thường được sử dụng là `public`, `private`, `protected`, and `internal`.

9. **Hàm tạo và Hàm hủy**:
    Hàm tạo là một phương thức đặc biệt được gọi khi một đối tượng được tạo. Nó khởi tạo trạng thái của đối tượng. Hàm hủy (còn được gọi là trình hoàn thiện) được gọi khi một đối tượng đang bị hủy, cho phép bạn dọn sạch tài nguyên.

10. **Thuộc tính và Phương thức**:
     Các thuộc tính được sử dụng để đóng gói các trường và cung cấp quyền truy cập có kiểm soát vào chúng. Các phương thức là các hàm xác định hành vi liên kết với một lớp.

Lập trình hướng đối tượng thúc đẩy tính mô đun, khả năng sử dụng lại và dễ bảo trì bằng cách tổ chức mã thành các đơn vị độc lập và có thể quản lý được. C# cung cấp hỗ trợ phong phú cho các khái niệm này, cho phép các nhà phát triển tạo các ứng dụng phức tạp với các cấu trúc và tương tác rõ ràng.

Example of Encapsulation(OOP) in c#:
Lập trình hướng đối tượng (OOP) là một mô hình lập trình tổ chức mã xung quanh các đối tượng và lớp. Trong C#, bạn có thể sử dụng OOP để tạo mã mô-đun và có thể tái sử dụng. Đây là một ví dụ thể hiện các nguyên tắc của OOP bằng C#:

```csharp
using System;

// Define a class named "Person"
class Person
{
    // Properties (attributes) of the class
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor to initialize the object
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Method to display the full name
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}

// Main class with the entry point
class Program
{
    static void Main(string[] args)
    {
        // Create instances (objects) of the "Person" class
        Person person1 = new Person("John", "Doe");
        Person person2 = new Person("Jane", "Smith");

        // Access properties and methods of the objects
        Console.WriteLine("Person 1: " + person1.GetFullName());
        Console.WriteLine("Person 2: " + person2.GetFullName());

        Console.ReadLine();
    }
}
```
Trong ví dụ này, chúng ta có một lớp `Person` đại diện cho một người có tên và họ. Nó có các thuộc tính cho các thuộc tính này và một phương thức để lấy tên đầy đủ. Lớp `Chương trình` chứa phương thức `Main`, đóng vai trò là điểm vào cho ứng dụng.

Đây là cách ví dụ hoạt động:

1. Chúng tôi định nghĩa lớp `Người` với các thuộc tính cho tên và họ. Hàm tạo khởi tạo các thuộc tính này khi một đối tượng được tạo.

2. Phương thức `GetFullName` được định nghĩa trong lớp `Person` để trả về tên đầy đủ được nối.

3. Trong lớp `Program`, chúng ta tạo hai thể hiện của lớp `Person`: `person1` và `person2`.

4. Chúng tôi sử dụng phương thức `GetFullName` để truy xuất và hiển thị tên đầy đủ của cả hai người.

5. Khi chương trình được thực thi, nó sẽ xuất ra tên đầy đủ của hai người.

Ví dụ này giới thiệu tính đóng gói (thuộc tính và phương thức), khởi tạo lớp và gọi phương thức—các khái niệm cốt lõi của lập trình hướng đối tượng. OOP cho phép bạn lập mô hình các thực thể trong thế giới thực, thúc đẩy tổ chức mã và cải thiện khả năng sử dụng lại và bảo trì mã.

Example of Inheritance(OOP) in C#:

Chắc chắn! Kế thừa là một khái niệm quan trọng trong lập trình hướng đối tượng (OOP) cho phép một lớp mới (được gọi là lớp dẫn xuất hoặc lớp con) kế thừa các thuộc tính và hành vi (phương thức) từ một lớp hiện có (được gọi là lớp cơ sở hoặc lớp cha). Đây là một ví dụ trong C#:

```csharp
using System;

class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public void Meow()
    {
        Console.WriteLine($"{Name} is meowing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy");
        dog.Eat();
        dog.Bark();
        dog.Sleep();

        Console.WriteLine();

        Cat cat = new Cat("Whiskers");
        cat.Eat();
        cat.Meow();
        cat.Sleep();
    }
}
```
Trong ví dụ này, chúng ta có một lớp cơ sở `Animal` với các thuộc tính và phương thức chung mà tất cả các loài động vật đều chia sẻ. Sau đó, chúng ta có hai lớp dẫn xuất `Dog` và `Cat`, kế thừa từ lớp `Animal`. Các lớp dẫn xuất có thể thêm các hành vi (phương thức) cụ thể của riêng chúng ngoài các hành vi mà chúng kế thừa.

Quyền lợi thừa kế:

1. **Khả năng sử dụng lại mã**: Các hành vi và thuộc tính phổ biến có thể được định nghĩa trong lớp cơ sở và được nhiều lớp dẫn xuất sử dụng lại.

2. **Tính đa hình**: Các lớp dẫn xuất có thể được coi là các thể hiện của lớp cơ sở, cho phép viết mã chung và linh hoạt hơn.

3. **Khả năng mở rộng**: Có thể thêm các lớp mới mà không cần sửa đổi mã hiện có bằng cách kế thừa từ lớp cơ sở thích hợp.

4. **Hệ thống phân cấp**: Kế thừa cho phép tạo hệ thống phân cấp của các lớp biểu thị mối quan hệ trong thế giới thực.

5. **Ghi đè**: Các lớp dẫn xuất có thể ghi đè các phương thức của lớp cơ sở để cung cấp các triển khai chuyên biệt.

Trong phương thức `Main` của lớp `Program`, bạn có thể thấy cách cả hai lớp `Dog` và `Cat` kế thừa từ lớp `Animal` và sử dụng các phương thức riêng của chúng cùng với các phương thức được kế thừa. Điều này thể hiện khái niệm kế thừa trong hành động.

Example of Polymorphism (OOP) in C#:

Chắc chắn! Đa hình là một khái niệm cơ bản khác trong lập trình hướng đối tượng (OOP) cho phép các đối tượng thuộc các lớp khác nhau được coi là đối tượng của một lớp cơ sở chung. Điều này cho phép mã linh hoạt và chung chung hơn. Đây là một ví dụ trong C#:

```csharp
using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Shape();
        shapes[1] = new Circle();
        shapes[2] = new Rectangle();

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}
```
Trong ví dụ này, chúng ta có một lớp cơ sở `Shape` với một phương thức ảo `Draw()`. Sau đó, chúng ta có hai lớp dẫn xuất `Circle` và `Rectangle`, cả hai đều ghi đè phương thức `Draw()`. Trong phương thức `Main`, chúng ta tạo một mảng các đối tượng `Shape` bao gồm các thể hiện của lớp cơ sở và các lớp dẫn xuất của nó.

Khi chúng ta gọi phương thức `Draw()` trên từng đối tượng trong mảng, tính đa hình sẽ phát huy tác dụng:

1. Đối tượng `Shape` gọi phương thức `Draw()` của chính nó.
2. Đối tượng `Circle` gọi phương thức `Draw()` bị ghi đè của nó.
3. Đối tượng `Rectangle` gọi phương thức `Draw()` bị ghi đè của nó.

Hành vi này thể hiện tính đa hình, trong đó các đối tượng thuộc các lớp khác nhau được xử lý thống nhất thông qua một giao diện chung (trong trường hợp này là phương thức `Draw()` của lớp `Shape`).

Lợi ích của đa hình:

1. **Tính linh hoạt**: Mã có thể hoạt động với các đối tượng thuộc các lớp khác nhau theo cách thống nhất, tăng tính linh hoạt và khả năng thích ứng của mã.

2. **Đơn giản hóa**: Hệ thống phân cấp phức tạp của các lớp có thể được biểu diễn bằng một giao diện chung.

3. **Khả năng mở rộng**: Có thể thêm các lớp mới mà không sửa đổi mã hiện có miễn là chúng tuân theo giao diện chung.

4. **Khả năng sử dụng lại mã**: Các giao diện và lớp cơ sở cho phép chia sẻ chức năng chung.

Trong ví dụ này, bạn có thể thấy tính đa hình cho phép chúng ta lặp qua một mảng các đối tượng `Shape` như thế nào và gọi phương thức `Draw()` thích hợp cho từng đối tượng, mặc dù các đối tượng thuộc các lớp dẫn xuất khác nhau.

Example of Abstraction (OOP) in C#:

Chắc chắn! Tính trừu tượng là một khái niệm quan trọng trong lập trình hướng đối tượng, cho phép bạn ẩn các chi tiết triển khai phức tạp và chỉ hiển thị các tính năng cần thiết của một đối tượng. Điều này giúp tạo mã dễ bảo trì và dễ hiểu hơn. Đây là một ví dụ về sự trừu tượng hóa trong C#:

```csharp
using System;

abstract class Shape
{
    public abstract void Draw();
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle();
        Shape rectangle = new Rectangle();

        circle.Draw();
        rectangle.Draw();
    }
}
```
Trong ví dụ này, chúng ta có một lớp trừu tượng `Shape` với một phương thức trừu tượng `Draw()`. Một lớp trừu tượng không thể được khởi tạo trực tiếp; nó có nghĩa là một cơ sở cho các lớp dẫn xuất. Các lớp `Circle` và `Rectangle` kế thừa từ lớp `Shape` và cung cấp các triển khai phương thức `Draw()` của riêng chúng.

Vì lớp `Shape` là trừu tượng nên nó chỉ định nghĩa giao diện (chữ ký phương thức) mà tất cả các lớp dẫn xuất phải triển khai. Các chi tiết thực tế về cách các hình được vẽ được để lại cho các lớp dẫn xuất.

Bằng cách sử dụng tính trừu tượng, phương thức `Main` có thể hoạt động với các phiên bản của `Shape` mà không cần biết chi tiết cụ thể về cách triển khai của từng hình dạng. Điều này cho phép tách các mối quan tâm và giảm độ phức tạp của mã.

Lợi ích của trừu tượng:

1. **Ẩn Độ phức tạp**: Các chi tiết triển khai được ẩn khỏi người dùng, giúp giao diện trở nên đơn giản và trực quan hơn.

2. **Tính mô đun của mã**: Các phần khác nhau của mã có thể được phát triển độc lập miễn là chúng tuân theo giao diện trừu tượng.

3. **Bảo trì**: Những thay đổi trong quá trình triển khai lớp dẫn xuất không ảnh hưởng đến mã sử dụng lớp cơ sở trừu tượng.

4. **Mở rộng trong tương lai**: Các lớp dẫn xuất mới có thể được thêm vào mà không thay đổi mã hiện có miễn là chúng triển khai các phương thức trừu tượng được yêu cầu.

Trong ví dụ này, bạn có thể thấy phương thức `Draw()` trong lớp `Shape` cung cấp lớp trừu tượng như thế nào. Điều này cho phép phương thức `Main` hoạt động với các hình dạng khác nhau mà không cần biết cách triển khai cụ thể của chúng.

77. Introduction To Classes And Objects

77. Giới thiệu về Lớp và Đối tượng

Trong lập trình hướng đối tượng (OOP), các lớp và đối tượng là những khái niệm cơ bản cho phép bạn tạo mã mô-đun và có thể tái sử dụng. Hãy khám phá những lớp và đối tượng trong C#:

1. **Lớp**:
Một lớp là một kế hoạch chi tiết hoặc khuôn mẫu để tạo các đối tượng. Nó định nghĩa cấu trúc và hành vi của các đối tượng thuộc về nó. Một lớp đóng gói dữ liệu (thuộc tính hoặc trường) và phương thức (hàm) hoạt động trên dữ liệu đó. Trong C#, một lớp được định nghĩa bằng từ khóa `class`.

Đây là cú pháp cơ bản của một lớp trong C#:

```csharp
class ClassName
{
    // Fields (data members)
    // Properties
    // Constructors
    // Methods
} 
```

2. **Đối tượng**:
Một đối tượng là một thể hiện của một lớp. Đó là một hiện thực cụ thể của bản thiết kế lớp. Các đối tượng có trạng thái (dữ liệu) và hành vi (phương thức) được định nghĩa bởi lớp của chúng. Các đối tượng cho phép bạn tương tác với dữ liệu và thực hiện các thao tác do lớp định nghĩa.

Đây là cách bạn tạo một đối tượng từ một lớp trong C#:

```csharp
ClassName objectName = new ClassName();
```
Đây là một ví dụ thể hiện các lớp và đối tượng:

```csharp
using System;

class Student
{
    // Fields
    public string Name;
    public int Age;

    // Constructor
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of the Student class
        Student student1 = new Student("Alice", 20);

        // Access object's fields and methods
        Console.WriteLine("Student 1 Info:");
        student1.DisplayInfo();

        // Create another object of the Student class
        Student student2 = new Student("Bob", 22);

        // Access object's fields and methods
        Console.WriteLine("Student 2 Info:");
        student2.DisplayInfo();
    }
}
```
Trong ví dụ này:

- Lớp `Sinh viên` định nghĩa hai trường (`Tên` và `Tuổi`), một hàm tạo để khởi tạo các trường đó và một phương thức (`DisplayInfo`) để hiển thị thông tin của sinh viên.
- Trong phương thức `Main` của lớp `Program`, hai đối tượng `Student` (`student1` và `student2`) được tạo bằng từ khóa `new`.
- Các trường của đối tượng được truy cập và sửa đổi bằng ký hiệu dấu chấm (`student1.Name`, `student1.Age`, v.v.).
- Phương thức `DisplayInfo` được gọi trên từng đối tượng để hiển thị thông tin của chúng.

Các lớp và đối tượng cho phép bạn tạo mã mô-đun, có thể tái sử dụng và có tổ chức. Bạn có thể tạo nhiều phiên bản của một lớp, mỗi phiên bản có dữ liệu và hành vi riêng, giúp mã của bạn dễ quản lý và có thể mở rộng hơn.

78. Our First Own Class

My code:

Class Car: 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Car
    {
        //constructor
        public Car()
        {
            Console.WriteLine("Car was created");
        }

        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopped!");
        }
    }
}

Main code: 
using System;

namespace ClassesAndObjects
{
    // A class in c# (and most other object-oriented programing language)
    // is a blueprint for creating object.
    // it defines a set of properties (data attributes)
    // and methods (functions) that an object of that class will have
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car();
            audi.Drive();
            Car bmw = new Car();
            Console.WriteLine("press 1 to stop the car!");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car drives indefinetely");
            }
        }
    }
}

79. Constructors and Member Variables

79. Constructor và biến thành viên

Trong C#, hàm tạo và biến thành viên đóng vai trò quan trọng trong việc tạo và khởi tạo đối tượng. Hàm tạo là các phương thức đặc biệt được sử dụng để khởi tạo các trường (biến thành viên) của một lớp khi một đối tượng được tạo. Hãy khám phá các hàm tạo và các biến thành viên chi tiết hơn:

1. **Member Variables**:
Các biến thành viên còn được gọi là các trường. Chúng là các thành phần dữ liệu của một lớp chứa các loại dữ liệu khác nhau, chẳng hạn như số nguyên, chuỗi, đối tượng, v.v. Các biến thành viên xác định trạng thái của một đối tượng và lưu trữ các giá trị dành riêng cho đối tượng đó.

Đây là cách bạn định nghĩa các biến thành viên trong một lớp:

```csharp
class ClassName
{
    // Member variables (fields)
    public int Age;
    public string Name;
    // ... other fields
}
```
2. **Constructors**:
Hàm tạo là một phương thức đặc biệt được gọi tự động khi một đối tượng được tạo từ một lớp. Nó chịu trách nhiệm khởi tạo các biến thành viên của đối tượng thành các giá trị cụ thể. Constructor giúp đảm bảo rằng một đối tượng ở trạng thái hợp lệ ngay khi nó được tạo.

Có thể có nhiều hàm tạo trong một lớp, cho phép bạn cung cấp các cách khởi tạo đối tượng khác nhau. Nếu bạn không định nghĩa rõ ràng một hàm tạo, C# sẽ cung cấp một hàm tạo mặc định khởi tạo các trường thành giá trị mặc định (ví dụ: trường số thành 0, trường chuỗi thành null).

Đây là cú pháp của một hàm tạo:

```csharp
class ClassName
{
    // Member variables (fields)
    public int Age;
    public string Name;

    // Constructor
    public ClassName(int age, string name)
    {
        Age = age;
        Name = name;
    }
}
```
Trong ví dụ trên, hàm tạo khởi tạo các biến thành viên `Tuổi` và `Tên` với các giá trị được cung cấp khi tạo một đối tượng.

Đây là một ví dụ minh họa việc sử dụng hàm tạo và biến thành viên:

```csharp
using System;

class Person
{
    // Member variables
    public string FirstName;
    public string LastName;
    public int Age;

    // Constructor
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // Method to display information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object using the constructor
        Person person1 = new Person("Alice", "Johnson", 25);

        // Access object's member variables
        Console.WriteLine("Person 1 Info:");
        person1.DisplayInfo();
    }
}
```
Trong ví dụ này:

- Lớp `Person` có các biến thành viên (`FirstName`, `LastName`, và `Age`) và một hàm khởi tạo khởi tạo các biến đó.
- Phương thức `Main` tạo đối tượng `Person` (`person1`) bằng cách sử dụng hàm tạo và truy cập các biến và phương thức thành viên của nó.
- Phương thức `DisplayInfo` hiển thị thông tin của người đó.

Hàm tạo và biến thành viên cho phép bạn thiết lập trạng thái ban đầu của đối tượng và cung cấp dữ liệu có ý nghĩa cho chức năng của chúng.

80. Using Multiple Constructors

Sử dụng nhiều hàm tạo trong C# là một cách hiệu quả để cung cấp tính linh hoạt khi tạo các đối tượng của một lớp. Các hàm tạo với các bộ tham số khác nhau cho phép bạn khởi tạo các đối tượng theo nhiều cách khác nhau mà không phải sao chép mã. Khái niệm này được gọi là quá tải hàm tạo.

Đây là cách bạn có thể sử dụng nhiều hàm tạo trong C#:

```csharp
class ClassName
{
    // Member variables (fields)
    public int Age;
    public string Name;

    // Constructor with parameters
    public ClassName(int age, string name)
    {
        Age = age;
        Name = name;
    }

    // Another constructor with different parameters
    public ClassName(string name)
    {
        Age = 0; // Default age
        Name = name;
    }
}
```
Trong ví dụ trên, lớp `ClassName` có hai hàm tạo. Một hàm tạo nhận cả tham số `tuổi` và `tên`, trong khi hàm tạo kia chỉ nhận tham số `tên` và khởi tạo trường `Tuổi` với giá trị mặc định là 0.

Đây là một ví dụ sử dụng lớp có nhiều hàm tạo:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Using the first constructor
        ClassName person1 = new ClassName(25, "Alice");

        // Using the second constructor
        ClassName person2 = new ClassName("Bob");

        // Display information for both persons
        Console.WriteLine("Person 1 Info: Age = {0}, Name = {1}", person1.Age, person1.Name);
        Console.WriteLine("Person 2 Info: Age = {0}, Name = {1}", person2.Age, person2.Name);
    }
}
```
Trong ví dụ này, đối tượng `ClassName` đầu tiên (`person1`) được tạo bằng hàm tạo có cả tham số `age` và `name`. Đối tượng thứ hai (`person2`) được tạo bằng hàm tạo chỉ nhận tham số `name`. Điều này cho phép bạn tạo các đối tượng với các cách khởi tạo khác nhau dựa trên hàm tạo mà bạn chọn.

Sử dụng nhiều hàm tạo có thể làm cho mã của bạn thân thiện hơn với người dùng bằng cách cung cấp các cách khác nhau để tạo đối tượng và đặt trạng thái ban đầu của chúng. Đó là một thực tế phổ biến trong lập trình hướng đối tượng để phục vụ cho các tình huống khác nhau mà không trùng lặp logic mã.

Coding Exercise 6: Constructors.

The main of this exercise is to create 3 constructors for the class Phone:

default constructor that sets all values to "unknown";

constructor that takes 2 arguments (company and model) and sets them respectively. The ReleaseDay should be set to "unknown";

constructor with 3 arguments (company, model, and release day);

Warning: You should not touch the given parts of the code! Create only 3 constructors.

My code:
using System;

namespace Coding.Exercise
{
    public class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;

        // Place for your constructors

        public Phone()
        {
            Company = "unknown";
            Model = "unknown";
            ReleaseDay = "unknown";
        }

        public Phone(string company, string model)
        {
            Company = company;
            Model = model;
            ReleaseDay = "unknown";
        }

        public Phone(string company, string model, string releaseDay)
        {
            Company = company;
            Model = model;
            ReleaseDay = releaseDay;
        }

        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }

    }


}

Mã C# này định nghĩa một lớp có tên `Phone` đại diện cho điện thoại di động. Lớp này có ba biến thành viên công cộng: `Company`, `Model` và `ReleaseDay`, lần lượt lưu trữ thông tin về công ty sản xuất, kiểu máy và ngày phát hành của điện thoại.

Lớp chứa ba hàm tạo để tạo các thể hiện của lớp `Phone` với các bộ giá trị ban đầu khác nhau:

1. Trình tạo mặc định:
    - Constructor này khởi tạo các biến thành viên với giá trị mặc định là "unknown".
    - Nó không nhận bất kỳ tham số nào.

2. Constructor với Company và Model:
    - Hàm tạo này nhận hai tham số: `company` và `model`.
    - Nó khởi tạo các biến thành viên `Company` và `Model` với các giá trị được cung cấp và đặt `ReleaseDay` thành "unknown".

3. Constructor với Company, Model và ReleaseDay:
    - Hàm tạo này nhận ba tham số: `company`, `model` và `releaseDay`.
    - Nó khởi tạo cả ba biến thành viên với các giá trị được cung cấp.

Lớp `Phone` cũng chứa một phương thức có tên `Introduce()`, phương thức này xuất thông tin về các thuộc tính của điện thoại bằng cách sử dụng `Console.WriteLine()`.

Đây là cách bạn có thể sử dụng lớp này:

using System;

namespace Coding.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            phone1.Introduce();

            Phone phone2 = new Phone("Apple", "iPhone 13");
            phone2.Introduce();

            Phone phone3 = new Phone("Samsung", "Galaxy S21", "2021-01-15");
            phone3.Introduce();
        }
    }
}
Trong ví dụ này, ba thể hiện của lớp `Phone` được tạo bằng cách sử dụng các hàm tạo khác nhau. Phương thức `Introduce()` được gọi trên mỗi phiên bản để hiển thị thông tin về điện thoại, bao gồm kiểu máy, công ty và ngày phát hành (nếu được cung cấp).

82. Shortcuts in VS
phím tắt hữu ích
Visual Studio có rất nhiều phím tắt có thể hữu ích cho các nhà phát triển C# để tăng năng suất. Dưới đây là một số trong số họ:

Chỉnh sửa và Điều hướng:

Ctrl + Space: Kích hoạt IntelliSense.

Ctrl + . (hoặc Alt + Enter): Mở menu tác vụ nhanh và tái cấu trúc.

F12: Vào định nghĩa.

Ctrl + - (trừ): Điều hướng trở lại.

Ctrl + Shift + - (trừ): Di chuyển về phía trước.

Ctrl + K, Ctrl + C: Comment các dòng đã chọn.

Ctrl + K, Ctrl + U: Bỏ ghi chú dòng đã chọn.

Ctrl + Shift + V: Di chuyển qua vòng clipboard.

Ctrl + M, Ctrl + M: Mở rộng hoặc thu gọn vùng mã.

Ctrl + K, Ctrl + D: Định dạng toàn bộ tài liệu.

Xây dựng và gỡ lỗi:

F5: Bắt đầu gỡ lỗi.

Ctrl + F5: Bắt đầu mà không cần gỡ lỗi.

F9: Chuyển đổi điểm dừng.

F10: Bước qua.

F11: Bước vào.

Shift + F11: Bước ra ngoài.

Ctrl + Shift + F5: Khởi động lại gỡ lỗi.

Ctrl + Shift + B: Xây dựng giải pháp.

Tìm kiếm và tìm kiếm:

Ctrl + F: Tìm.

Ctrl + H: Thay thế.

Ctrl + Shift + F: Tìm trong Tệp.

Ctrl + Shift + H: Thay thế trong Tệp.

Ctrl + T (hoặc Ctrl + ,): Tìm kiếm tệp, loại, thành viên, v.v. trong giải pháp của bạn.

F7: Chuyển đổi giữa chế độ xem mã và chế độ xem thiết kế.

Cửa sổ và tab:

Ctrl + Alt + L: Hiện Solution Explorer.

Ctrl + \ , E: Hiện danh sách lỗi.

Ctrl + K, Ctrl + R: Hiển thị tham chiếu đến biểu tượng dưới con trỏ.

Alt + F7 (hoặc Shift + Alt + F7): Duyệt qua định nghĩa, khai báo hoặc tham chiếu trước đó (tiếp theo).

Ctrl + Tab: Điều hướng các tệp đang hoạt động và cửa sổ công cụ.

tái cấu trúc:

Ctrl + R, Ctrl + R: Đổi tên.

Ctrl + R, Ctrl + M: Phương pháp giải nén.

Ctrl + R, Ctrl + E: Đóng gói trường.

Các phím tắt này có thể được tùy chỉnh trong Visual Studio. Bạn có thể xem và thay đổi tổ hợp phím bằng cách vào Công cụ -> Tùy chọn -> Môi trường -> Bàn phím. Hãy nhớ rằng thực hành tạo nên sự hoàn hảo; bạn càng sử dụng các phím tắt này, trải nghiệm viết mã của bạn sẽ càng hiệu quả hơn.

85. Understanding private vs public for methods and variables

Trong C#, các công cụ sửa đổi quyền truy cập như `private` và `public` xác định khả năng hiển thị và khả năng truy cập của các phương thức và biến trong một lớp. Dưới đây là giải thích về ý nghĩa của từng công cụ sửa đổi quyền truy cập:

1. **private:**
    - Khi một phương thức hoặc biến được đánh dấu là `private`, nó chỉ có thể được truy cập và sử dụng trong cùng một lớp mà nó được khai báo.
    - Nó không thể truy cập từ bên ngoài lớp, ngay cả trong các lớp dẫn xuất (trừ khi bạn sử dụng một số hình thức phản ánh, đó là một chủ đề nâng cao hơn).
    - Các thành viên ` private ` được đóng gói và ẩn khỏi mã bên ngoài, đảm bảo rằng các chi tiết triển khai bên trong của một lớp không bị lộ ra thế giới bên ngoài.

Ví dụ:
```csharp
class MyClass
{
    private int myPrivateVariable;

    private void MyPrivateMethod()
    {
        // Some implementation
    }
}
```
2. ** public:**
    - Khi một phương thức hoặc biến được đánh dấu là `public`, nó có thể được truy cập từ bất kỳ đâu, cả trong cùng một lớp và từ bên ngoài lớp.
    - Nó là công cụ sửa đổi truy cập dễ dãi nhất và thường được sử dụng cho các phương thức và thuộc tính có nghĩa là một phần của giao diện chung của lớp.
    - Các thành viên `public` có thể nhìn thấy và truy cập được đối với các lớp và mã khác.

Ví dụ:
```csharp
class MyClass
{
    public int MyPublicVariable;

    public void MyPublicMethod()
    {
        // Some implementation
    }
}
```
Tóm tắt:
- Các thành viên ` private ` chỉ có thể truy cập được trong cùng một lớp.
- Các thành viên `public` có thể được truy cập từ mọi nơi, kể cả bên ngoài lớp.

Điều quan trọng là chọn công cụ sửa đổi truy cập phù hợp dựa trên khả năng hiển thị dự kiến và cách sử dụng các phương thức và biến của lớp của bạn. Việc sử dụng ` private ` giúp gói gọn các chi tiết nội bộ của một lớp và ngăn truy cập ngoài ý muốn, trong khi sử dụng ` public ` cho phép tương tác được kiểm soát và xác định rõ ràng với giao diện lớp của bạn từ mã bên ngoài.

86. Setters in Csharp

Trong C#, một setter là một phương thức được sử dụng để gán một giá trị mới cho một thuộc tính của một lớp. Đó là một phần của khái niệm đóng gói, cho phép bạn kiểm soát cách các giá trị được gán cho các thuộc tính của một đối tượng. Setters thường được sử dụng kết hợp với các thuộc tính để cung cấp một cách có kiểm soát để sửa đổi trạng thái bên trong của một đối tượng.

Đây là cách setters hoạt động trong C#:

```csharp
class MyClass
{
    private int myField;

    public int MyProperty
    {
        get
        {
            return myField;
        }
        set
        {
            // This is the setter
            if (value >= 0)
            {
                myField = value;
            }
        }
    }
}
```
Trong ví dụ này:
- `myField` là trường riêng chứa giá trị thực của thuộc tính.
- `MyProperty` là một thuộc tính công cộng có getter và setter.
- getter lấy giá trị của `myField`.
- setter được sử dụng để đặt giá trị của `myField`, nhưng nó bao gồm một điều kiện chỉ cho phép gán các giá trị dương.

Khi bạn sử dụng setter để gán giá trị cho thuộc tính, điều kiện bên trong setter sẽ được kiểm tra. Nếu điều kiện được đáp ứng, giá trị sẽ được gán cho `myField`. Nếu không, phép gán sẽ bị bỏ qua và thuộc tính vẫn giữ nguyên giá trị trước đó.

Đây là cách bạn sẽ sử dụng setter:

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();
        myObject.MyProperty = 42;  // This is using the setter
        int value = myObject.MyProperty;  // This is using the getter
        Console.WriteLine(value);  // Output: 42

        myObject.MyProperty = -10;  // This assignment is skipped due to the condition in the setter
        int newValue = myObject.MyProperty;  // The value is still 42
        Console.WriteLine(newValue);  // Output: 42
    }
}
Trong ví dụ này, setter đảm bảo rằng chỉ các giá trị dương được gán cho thuộc tính. Nếu bạn cố gắng gán một giá trị âm, thì phép gán đó sẽ bị bỏ qua và thuộc tính sẽ giữ lại giá trị trước đó.

Sử dụng setters và getters cho phép bạn kiểm soát cách các giá trị được gán và truy xuất từ các thuộc tính, cho phép bạn triển khai xác thực, tính toán và logic khác nếu cần.

87. Getters in Csharp

Trong C#, getter là một phương thức được sử dụng để truy xuất giá trị của một thuộc tính trong một lớp. Getters là một phần thiết yếu của khái niệm đóng gói, cho phép bạn kiểm soát cách các giá trị của thuộc tính được truy cập từ bên ngoài lớp. Getters thường được sử dụng cùng với các thuộc tính để cung cấp một cách có kiểm soát để hiển thị trạng thái bên trong của một đối tượng.

Đây là cách getter hoạt động trong C#:

class MyClass
{
    private int myField = 10;

    public int MyProperty
    {
        get
        {
            // This is the getter
            return myField;
        }
    }
}
Trong ví dụ này:
- `myField` là trường riêng chứa giá trị thực của thuộc tính.
- `MyProperty` là một thuộc tính công cộng chỉ có một getter.
- Bộ thu lấy giá trị của `myField` và trả về nó.

Khi bạn sử dụng trình thu thập để truy cập giá trị của thuộc tính, mã trong trình thu thập được thực thi và giá trị được trả về cho trình gọi.

Đây là cách bạn sẽ sử dụng getter:

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();
        int value = myObject.MyProperty;  // This is using the getter
        Console.WriteLine(value);  // Output: 10
    }
}
Trong ví dụ này, bạn sử dụng trình thu thập dữ liệu để truy cập giá trị của `MyProperty`, từ đó truy xuất giá trị của trường riêng `myField`.

Getters rất hữu ích để hiển thị trạng thái của một đối tượng theo cách được kiểm soát. Bằng cách đóng gói dữ liệu thực tế trong các trường riêng tư và cung cấp getters để truy cập chúng, bạn có thể duy trì quyền kiểm soát cách dữ liệu được truy cập và ngăn các sửa đổi không mong muốn từ bên ngoài lớp.

88. Properties in Csharp

Trong C#, các thuộc tính là một cách để đóng gói dữ liệu và cung cấp quyền truy cập có kiểm soát vào nó. Các thuộc tính kết hợp hành vi của các trường (biến) và phương thức (getters và setters) thành một thực thể duy nhất, làm cho chúng linh hoạt hơn và cung cấp cú pháp rõ ràng hơn để truy cập và sửa đổi dữ liệu của một lớp. Chúng cho phép bạn xác định cách các giá trị được truy xuất và gán cho một thành viên dữ liệu cụ thể của một lớp.

Đây là cách các thuộc tính hoạt động trong C#:

class MyClass
{
    private int myField;

    public int MyProperty
    {
        get
        {
            return myField;  // Getter
        }
        set
        {
            myField = value;  // Setter
        }
    }
}
Trong ví dụ này:
- `myField` là trường riêng chứa giá trị thực của thuộc tính.
- `MyProperty` là thuộc tính công khai có cả getter và setter.

Khi bạn sử dụng thuộc tính để truy cập hoặc sửa đổi giá trị của nó, trình getter hoặc setter tương ứng sẽ được thực thi.

Đây là cách bạn sẽ sử dụng tài sản:

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        myObject.MyProperty = 42;  // This is using the setter
        int value = myObject.MyProperty;  // This is using the getter

        Console.WriteLine(value);  // Output: 42
    }
}
Trong ví dụ này, bạn đặt giá trị của `MyProperty` bằng cách sử dụng bộ thiết lập và sau đó truy xuất giá trị bằng cách sử dụng bộ lấy.

Thuộc tính cung cấp các lợi ích như:
- Đóng gói: Bạn có thể ẩn các chi tiết triển khai cơ bản và kiểm soát cách dữ liệu được truy cập và sửa đổi.
- Xác thực: Bạn có thể thêm logic xác thực trong bộ thiết lập để đảm bảo rằng chỉ các giá trị hợp lệ được chỉ định.
- Khả năng đọc mã: Các thuộc tính cung cấp một cách rõ ràng và nhất quán để truy cập các thành viên của lớp, giúp mã của bạn dễ đọc và dễ bảo trì hơn.

C# cũng cung cấp các thuộc tính được triển khai tự động, trong đó trình biên dịch sẽ tự động tạo trường sao lưu cho bạn. Đây là một ví dụ:

class MyClass
{
    public int MyProperty { get; set; }
}
Trong trường hợp này, trình biên dịch sẽ tự động tạo trường sao lưu riêng và các phương thức getter và setter. Các thuộc tính được triển khai tự động là một cách thuận tiện để tạo các thuộc tính đơn giản mà không cần xác định rõ ràng trường và phương thức sao lưu.

89. Auto Implemented Properties

Các thuộc tính được triển khai tự động là một cách ngắn gọn để xác định các thuộc tính trong C# mà không cần xác định rõ ràng trường sao lưu hoặc các phương thức getter và setter. Chúng đặc biệt hữu ích cho các thuộc tính đơn giản không yêu cầu logic hoặc xác thực bổ sung.

Đây là cú pháp cho các thuộc tính được triển khai tự động:

class MyClass
{
    public int MyProperty { get; set; }
}
Trong ví dụ này, `MyProperty` là thuộc tính được triển khai tự động. Đằng sau hậu trường, trình biên dịch C# tự động tạo trường sao lưu riêng và các phương thức getter và setter tương ứng.

Bạn cũng có thể chỉ định mức truy cập cho getter và setter một cách độc lập:

class MyClass
{
    public int MyProperty { get; private set; }
}
Trong trường hợp này, getter là công khai, cho phép mã bên ngoài đọc giá trị thuộc tính, trong khi setter là riêng tư, hạn chế quyền truy cập của nó trong lớp.

Các thuộc tính được triển khai tự động là một cách thuận tiện để giảm mã soạn sẵn khi xác định các thuộc tính không yêu cầu logic tùy chỉnh. Tuy nhiên, hãy nhớ rằng bạn sẽ không có quyền kiểm soát trực tiếp đối với tên của trường sao lưu nếu bạn cần truy cập nó trong các tình huống nâng cao hơn.

Đây là cách bạn sẽ sử dụng thuộc tính được triển khai tự động:

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        myObject.MyProperty = 42;  // Setting the property value
        int value = myObject.MyProperty;  // Getting the property value

        Console.WriteLine(value);  // Output: 42
    }
}
Các thuộc tính được triển khai tự động cung cấp một cách rõ ràng và súc tích để tạo các thuộc tính với chi phí mã tối thiểu.

90. Read-Only and Write-Only Properties

Trong C#, bạn có thể tạo các thuộc tính chỉ đọc và chỉ ghi bằng cách sử dụng các công cụ sửa đổi truy cập tùy chỉnh và bỏ qua setter hoặc getter tương ứng. Các thuộc tính này cho phép bạn kiểm soát xem một thuộc tính có thể được đọc hoặc ghi từ bên ngoài lớp hay không.

1. ** Read-Only Property:**
Thuộc tính chỉ đọc chỉ cung cấp một getter, nghĩa là bạn có thể truy xuất giá trị của nó nhưng không thể thay đổi nó từ bên ngoài lớp. Để tạo thuộc tính Read-Only Property, bạn bỏ qua setter.

class MyClass
{
    private int myField;

    public int MyProperty
    {
        get { return myField; }
    }

    public MyClass(int value)
    {
        myField = value;
    }
}
Trong ví dụ này, `MyProperty` là một thuộc tính chỉ đọc vì nó chỉ có một getter. Giá trị được đặt trong hàm tạo của lớp.

2. ** Write-Only Property:**
Thuộc tính chỉ ghi chỉ cung cấp một setter, cho phép bạn đặt giá trị của nó nhưng không truy xuất giá trị đó từ bên ngoài lớp. Để tạo một thuộc tính chỉ ghi, bạn bỏ qua getter.

class MyClass
{
    private int myField;

    public int MyProperty
    {
        set { myField = value; }
    }
}
Trong ví dụ này, `MyProperty` là một thuộc tính chỉ ghi vì nó chỉ có một setter. Bạn có thể đặt giá trị bằng cách sử dụng thuộc tính, nhưng bạn không thể truy xuất giá trị đó.

Đây là cách bạn sẽ sử dụng các thuộc tính chỉ đọc và chỉ ghi:

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass(42);

        int value = myObject.MyProperty; // Reading the read-only property

        myObject.MyProperty = 100; // Writing to the write-only property
    }
}
Các thuộc tính chỉ đọc và chỉ ghi cung cấp một cách để hiển thị quyền truy cập cụ thể vào dữ liệu trong một đối tượng trong khi kiểm soát hướng truy cập.

91. Members And Finalizers/Destructors

Trong C#, các thành viên đề cập đến các phần tử khác nhau trong một lớp xác định hành vi, trạng thái và mối quan hệ của nó với các lớp khác. Các thành viên có thể bao gồm các trường, thuộc tính, phương thức, sự kiện, bộ chỉ mục và các kiểu lồng nhau. Mặt khác, bộ hoàn thiện, còn được gọi là bộ hủy, là các phương thức đặc biệt trong các lớp C# được gọi tự động khi một đối tượng sắp được thu gom rác. Chúng cho phép bạn thực hiện dọn dẹp và giải phóng tài nguyên trước khi một đối tượng bị xóa khỏi bộ nhớ.

Đây là bảng phân tích các thành viên và bộ hoàn thiện trong C#:

1. **Thành viên:**
    Các thành viên là các khối xây dựng của một lớp xác định các đặc điểm và hành vi của nó. Chúng bao gồm:

    - **Trường:** Đây là các biến lưu trữ dữ liệu cho lớp. Chúng có thể là công khai, riêng tư, được bảo vệ hoặc nội bộ.
   
    - **Thuộc tính:** Thuộc tính giống như các phương thức cung cấp quyền truy cập có kiểm soát vào các trường. Chúng cho phép bạn đóng gói dữ liệu và cung cấp logic tùy chỉnh khi nhận hoặc đặt giá trị.
   
    - **Phương thức:** Phương thức là các hàm trong một lớp xác định hành vi của nó. Chúng có thể nhận các tham số, thực hiện các thao tác và trả về các giá trị.
   
    - **Sự kiện:** Sự kiện cho phép giao tiếp giữa các đối tượng. Chúng được sử dụng để thông báo cho các phần khác của chương trình khi một hành động hoặc điều kiện cụ thể xảy ra.
   
    - **Bộ chỉ mục:** Bộ chỉ mục cung cấp cách truy cập các phần tử trong một lớp bằng cú pháp giống như mảng.
   
    - **Kiểu lồng nhau:** Kiểu lồng nhau là các lớp, cấu trúc hoặc enum được định nghĩa trong một lớp khác. Chúng giúp tổ chức mã và đóng gói các chức năng liên quan.

2. **Finalizers (Destructors):**
    Bộ hoàn thiện (còn được gọi là bộ hủy) là một phương thức đặc biệt được bộ thu gom rác tự động gọi trước khi một đối tượng bị hủy và bộ nhớ được thu hồi. Bộ hoàn thiện được sử dụng để dọn sạch các tài nguyên không được quản lý, chẳng hạn như bộ xử lý tệp hoặc kết nối mạng, được liên kết với một đối tượng. Chúng được định nghĩa bằng cách sử dụng ký tự dấu ngã (`~`) theo sau là tên lớp và không có tham số.

class MyClass
{
    ~MyClass()
    {
        // Cleanup code for unmanaged resources
    }
}
    Điều quan trọng cần lưu ý là các công cụ hoàn thiện nên được sử dụng một cách thận trọng vì chúng có thể ảnh hưởng đến hiệu suất. Trong nhiều trường hợp, bạn có thể sử dụng giao diện `IDisposable` cùng với mẫu `Dispose` để quản lý tài nguyên một cách rõ ràng và giải phóng chúng theo cách có kiểm soát hơn.

Tóm lại, các thành viên xác định cấu trúc và hành vi của một lớp, trong khi các bộ hoàn thiện (bộ hủy) cung cấp một cách để thực hiện các tác vụ dọn dẹp trước khi một đối tượng được thu gom rác.

My code:
Class members:
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersC
{
    class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property - exposes jobTitle safely - properties start with a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old", memberName, jobTitle, age);
            }

        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Destruction of Members object");
        }

    }
}

Class Program:
using MembersAndFinalizersDestructors;
using MembersC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersAndFinalizersDestructors
{
    class Program
    {

        static void Main(string[] args)
        {
            Members member1 = new Members();
            member1.Introducing(true);
            Console.ReadKey();
        }


    }
}
