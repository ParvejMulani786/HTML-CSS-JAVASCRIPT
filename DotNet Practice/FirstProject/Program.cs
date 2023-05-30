

using System;

public class Program
{
	public static void Main()
	{
		Employee emp = new Employee();
		emp.FirstName = "Steve";
		emp.LastName = "Jobs";
		emp.EmployeeId = 1;
		emp.CompanyName = "Apple";
		
		Console.WriteLine(emp.GetFullName()); //base class method
		Console.WriteLine(emp.EmployeeId); 
		Console.WriteLine(emp.CompanyName); 

	}
}

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetFullName(){ 
        return FirstName + " " + LastName;
    }
}

class Employee : Person
{
    public int EmployeeId { get; set; }
    public string CompanyName { get; set; }
    
}
/* class Person{
    public string firstName{get;set;}
    public string lastName{get;set;}

    public void full_Name(){
        Console.WriteLine("Full Name: "+firstName+" "+lastName);
    }
}
class Employee:Person{
    public int empId{get;set;}
    public String deptName{get;set;}
}
class Program{
    public static void Main(String[] ar){
        Employee e=new Employee();
        e.firstName("PARVEJ");
        e.lastName("Mulani");
        e.full_Name();
        e.empId(1);
        e.deptName("CIVIL");
        Console.WriteLine(e.firstName);
        Console.WriteLine(e.lastName);
        Console.WriteLine( e.empId);
        Console.WriteLine( e.deptName);
    }
} */
































/* //Method Overlodaing
class Calculation{

public int plusNum(int x,int y){
return x+y;
}

public double plusNum(double x,double y){
return x+y;
}
}
class Program{
public static void Main(String[] args){
Calculation cal=new Calculation();
int res1=cal.plusNum(8,5);
double res2=cal.plusNum(4.5,8.6);
Console.WriteLine("Result Int: "+res1);
Console.WriteLine("Result Double: "+res2);
}
}
 */



/*  Method Overriding
class Person{
    public virtual void greet(){
        Console.WriteLine("Hello, I am a Person");
    }
}
class Employee:Person{
    public override void greet(){
        Console.WriteLine("Hello , I am Employee");
    }
}

class Program{
    public static void display(Person p){
        p.greet();
    }
    public static void Main(String[] args){
        Person p1=new Person();
            display(p1);
        //p1.greet(); //Hello, I am a Person

        Person p2=new Employee();
            display(p2);
       // p2.greet(); //Hello , I am Employee
       Employee e=new Employee();
            display(e);
    }
 */
