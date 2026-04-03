using System;

class Operators {
    static void Main() {
	//Arithmetic Operators

        int x = 8, y = 3;

        Console.WriteLine(x + y); // Addition - 11
        Console.WriteLine(x - y); // Subtraction - 5
        Console.WriteLine(x * y); // Multiplication - 24
        Console.WriteLine(x / y); // Division - 2
        Console.WriteLine(x % y); // Modulus - 2

	//Relational Operators

	Console.WriteLine(x==y); //Equals To - false
	Console.WriteLine(x!=y); //Not Equals To - true 
	Console.WriteLine(x>y); // Greater than - true
	Console.WriteLine(x<y); // less than - false
	Console.WriteLine(x>=y); // greater than or equals to -true
	Console.WriteLine(x<=y); //less than or equals to - false

	//Logical Operator
	
	bool a = true;
	bool b = false;

	Console.WriteLine(a&&b); // return true if both a and b are true
	Console.WriteLine(a||b); //  return true if at least one of a and b are true
	Console.WriteLine(!a); // return the reverse of a

	//Assignment Operators
	
	x+=y;
	Console.WriteLine(x); //add y to x and than store the new value in x
	x-=y;
	Console.WriteLine(x); //subtract y from the new x and than store the new value in x
	x*=y;
	Console.WriteLine(x); //multiply y with x and than store the new value in x
	x/=y;
	Console.WriteLine(x); // divide y with x and put the new value in  x
	x%=y;
	Console.WriteLine(x); //modulus y with x and store the reminder of that in x;


	//Unary operators

	int e = 11;
	Console.WriteLine(++e); //12 increment before output
	Console.WriteLine(e++); //12 increment after output
	Console.WriteLine(e); //13
	Console.WriteLine(--e); //12 decrement before output
	Console.WriteLine(e--); //12 decrement after output
	Console.WriteLine(e); //11

	//Ternary Operator
	
	int first = 10;
	int second = 20;

	Console.WriteLine((first>second)?first:second);

	//is operator
	Console.WriteLine(first is int); //ture if int data type

    }
}
