using System;
using System.Collections;

namespace ConsoleApp18
{
    class Car:ICloneable, IEnumerable, IEnumerator
    {
       private String model="Peugeot 308" ;
        Engine engine;
        public Car() { }
        public Car(String model,Engine engine) {
            this.model = model;
            this.engine = engine;
        }
        public Car(Car car)
        {
            model = car.model;
            engine = new Engine(car.engine);

        }
        public object Clone()
        {
           return  new Car(model,(Engine)engine.Clone());
        }

        public void setEngine(Engine engine)
        {
            this.engine = engine;
        }
        public override String ToString()
        {
            return "Model: "+model+"; Engine: "+engine.getMark();
        }

    }
    class Engine:ICloneable
    {
        public String mark="Renault";
        double volume = 1.8;
        public Engine() { }
        public Engine(String mark,double volume)
        {
            this.mark = mark;
            this.volume = volume;
        }
        public Engine(Engine engine) {
            mark = engine.mark;
            volume = engine.volume;
        }
        public String getMark()
        {
            return mark;
        }
        public object Clone()
        {
            return new Engine(mark, volume);
        }
    }
    class NoGen
    {
        public Object obj;
        public NoGen(Object obj)
        {
            this.obj = obj;
        }
        public String getObjType()
        {
            return obj.GetType().Name;
        }
        public Object getObj()
        {
            return obj;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NoGen noGen = new NoGen(45);
            Console.WriteLine("Type: " + noGen.getObjType());
            String str = (String)noGen.getObj();
            Console.WriteLine(str);
            /*
            Engine engine = new Engine();
            Car car = new Car();
            car.setEngine(engine);
            Car cloneCar = (Car)car.Clone();

            Car cloneCarConstruct = new Car(car);
            engine.mark = "Volvo";
            Console.WriteLine("Car: "+car);
            Console.WriteLine("CloneCar: " + cloneCar);
    */

        }
    }
}
