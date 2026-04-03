using System;
using Project1;
using Project2;

namespace Project1{
    //public class ->can access within the class
    public class One{
        public int value =5;
        private int secret =6;
        protected int semiSecret =4;
        internal int onlyThis = 3;
        protected internal int relation = 7;
        // private protected int safeValue = 10;


        public void PublicMethod(){
            Console.WriteLine(value);
        }
        private void PrivateMethod(){
            Console.WriteLine("this is from the private method"+secret);
        }
        //can access in the same class
        public void CallPrivate(){
            PrivateMethod();
        }
        protected void ProtectedMethod(){
            Console.WriteLine("this is from a Protected Method"+semiSecret);
        }
        // can acces in the same class
        public void CallProtected(){
            ProtectedMethod();
        }

        public void InternalMethod(){
            Console.WriteLine("Internal can be accesed in same class"+onlyThis);
        }

        protected void ProtectedInternalMethod(){
            Console.WriteLine("this is from a Protected Internal Method"+relation);
        }
        // can acces in the same class
        public void CallProtectedInternal(){
            ProtectedInternalMethod();
        }

        protected void PrivateProtectedMethod(){
            Console.WriteLine("this is from a Private Protected Method");
        }
        // can acces in the same class
        public void CallPrivateProtected(){
            PrivateProtectedMethod();
        }


    }

    public class Two:One{
        public void ChildMethod(){
            Console.WriteLine("can Access in child classes"+value);
            //private can not be accessed in sub classes
            Console.WriteLine("Protected can be accesed in drived classes"+semiSecret);
            Console.WriteLine("Internal can be accessed in sub classes inn same assembly"+onlyThis);
            Console.WriteLine("Protected Internal can be accesed in drived classes"+relation);
            Console.WriteLine("Private Protected can be accesed in drived classes");
        }
    }

    class AccessModifiers{
        static void Main(String[] args){
            One first = new One();
            first.PublicMethod();

            Two second = new Two();
            second.ChildMethod(); 

            Three third = new Three();
            third.ChildMethod1();
            //can access in differnt class in same assembly
            Console.WriteLine(first.value);

            Four fourth = new Four();
            fourth.DifferentMethods();

            first.CallPrivate();

            //private can not be accessed in differnt class in same assembly without getter and setter

            first.CallProtected();

            //protected can not be accessed in different class in same assembly

            first.InternalMethod();
            //can be accessed in different class same assembly
            Console.WriteLine(first.onlyThis);

            first.CallProtectedInternal();
            //can be accessed in different class same assembly
            Console.WriteLine(first.relation);

            first.CallPrivateProtected();
            //private protected can not be accessed in differnt class in same assembly


        }
    }
}

namespace Project2{
    public class Three:One{
        public void ChildMethod1(){
           
            Console.WriteLine("can Access in child classes outside the assembly"+value);
            Console.WriteLine("Protected can be accesed in drived classes in different assembly"+semiSecret);
            Console.WriteLine("Protected Internal can be accesed in drived classes in different assembly"+relation);
        }
        //private can not be accessed in sub class in differnet assembly 
        //internal can not be accessed in sub class in differnet assembly 
        //private protected can not be accessed in sub class in differnet assembly 
    }

    public class Four{
        public void DifferentMethods(){
             One obj = new One();
            Console.WriteLine("can Access in other class in different assembly"+ obj.value);
        }
        //private can not be accessed in different class in differnet assembly 
        //protected can not be accessed in differnt class in different assembly
        //internal can not be accessed in sub class in differnet assembly 
        //protected Internal can not be accessed in differnt class in different assembly
        //private protected can not be accessed in different class in differnet assembly 
    }
}