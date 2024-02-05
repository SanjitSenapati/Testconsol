class A
{
    // string s = "killer program";
    public virtual string method1(string ac)
    {
        return ac; 
    }
}
    class B : A
    {
        public override string method1(string hg)
        {
        string sw = "hello from derive class";
        return sw;
        }

    }

        class Calling
        {
            public static void Main(String[]args)
            {
        A a=new A();
        string asd1 = a.method1("Hello from base class");
        Console.WriteLine(asd1);
                B b = new B();
                 string asd=b.method1(" ");
        Console.WriteLine(asd);

            }
    }



