using System;
namespace SA52Paper
{
    public interface InterfaceA
    {
        public void MethodA();
    }
    public interface InterfaceB
    {
        public void MethodB();
    }
    public interface InterfaceC
    {
        public void MethodC();
    }

    public class A : InterfaceA,InterfaceC
    {
        public virtual void MethodA()
        {
            Console.WriteLine("Method A");
        }


        public virtual void MethodC()
        {
            Console.WriteLine("Method C"); ;
        }
    }
    public class B : A,InterfaceB
    {
        public override void MethodA()
        {
            base.MethodA();
            Console.WriteLine("Method A");
        }
        public virtual void MethodB()
        {
            Console.WriteLine("Method B");
        }

    }
    public class C : InterfaceA, InterfaceB
    {
        public void MethodA()
        {
            Console.WriteLine("Method A");
        }

        public void MethodB()
        {
            Console.WriteLine("Method B");
        }
    }
    public class D : B
    {
        public override void MethodA()
        {
            Console.WriteLine("Method A");
        }

        public override void MethodB()
        {
            Console.WriteLine("Method B");
        }

        public override void MethodC()
        {
            base.MethodC();
            Console.WriteLine("Method C"); ;
        }
    }
    public class E : InterfaceB, InterfaceC
    {
        public void MethodB()
        {
            Console.WriteLine("Method B");
        }

        public void MethodC()
        {
            Console.WriteLine("Method B"); ;
        }
    }

}

