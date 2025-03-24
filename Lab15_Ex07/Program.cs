using static System.Console;

Derived_2 d2 = new Derived_2();
Base b = (Base) d2;
Derived_1 d1 = (Derived_1) d2;

b.A();
d1.A();
d2.A();

class Base
{
    public virtual void A()
    {
        WriteLine("Base.A()");
    }
}

class Derived_1 : Base
{
    // ลบคำว่า 'sealed' ออก เพื่อให้สามารถ override ใน Derived_2 ได้
    public override void A()
    {
        WriteLine("Derived_1.A()");
    }
}

class Derived_2 : Derived_1
{
    // ตอนนี้สามารถ override A ได้
    public override void A()
    {
        WriteLine("Derived_2.A()");
    }
}
