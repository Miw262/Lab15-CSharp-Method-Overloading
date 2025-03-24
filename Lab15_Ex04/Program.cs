using static System.Console;  // เพิ่มบรรทัดนี้

var b = new Base();
var d1 = new Derived_1();
var d2 = new Derived_2();

b.A();
d1.A();
d2.A();

class Base
{
    public virtual void A()
    {
        WriteLine("Base.A()");  // ใช้ WriteLine ได้โดยไม่ต้องระบุ Console
    }
}

class Derived_1 : Base
{
    public override void A()
    {
        WriteLine("Derived_1.A()");
    }
}

class Derived_2 : Derived_1
{
    public override void A()
    {
        WriteLine("Derived_2.A()");
    }
}
