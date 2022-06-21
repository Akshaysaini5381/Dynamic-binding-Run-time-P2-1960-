using System;

namespace Dynamic_binding_Run_time_P2
{
    class mix_1960
    {
        public static void call(mix_1960 m)
        {
            m.show();
        }
        public virtual void show()
        {
            Console.WriteLine("I am Parent :");
        }
    }
    class child_1980:mix_1960
    {
        public override void show()
        {
            Console.WriteLine("I am child-1");
        }
    }
    class child_1982:child_1980
    {
        public override void show()
        {
            Console.WriteLine("I am child-2");
        }
    }
    class Demo_2020:child_1982
    {
        static void Main(string[] args)
        {
            mix_1960 p = new mix_1960();
            child_1980 ch_1 = new child_1980();
            child_1982 ch_2 = new child_1982();
            mix_1960.call(p);
            mix_1960.call(ch_1);
            mix_1960.call(ch_2);

        }
    }
}
