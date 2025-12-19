using System;

class DataTypes{
	static void Main(String[] args){
		//Value or Primitive Data type
		
		// range 0 to 255
		byte data = 255;

		// size is 16bit 
		Short roll = 32000;

		//size is 32bit 
		int number = Math.Pow(299,300);

		//size is 64bit 
		long id = 9876543212323432123;

		// size is 32 bit IEEE floating point
		float myValue = 3.14f;

		//size is 64bit IEEE floating point 
		double secondValue = 3.14;

		// size  	is 16bit unicode character 
		char name = 'pushpak';

		// 1 bit
		bool lie = true;  

		//Type Casting of Value Data Type

		//Implicit Type casting
		short a = data;
		int b = a;
		long c = b;
		float d = c;
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
		Console.WriteLine(d);

		//Explicit Type Casting
		
		//larger data into smaller data type
		int i = (int)sceondValue;
		COnsole.WriteLine(i);

		//using inbuild Type Conversion Methods
		
		Console.WriteLine(Convert.ToString(myValue));
		Console.WriteLine(Convert.ToInt32(SecondValue));
		Console.WriteLine(Convert.ToDouoble(number));
		
	}
}