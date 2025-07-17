namespace HandsOnDI
{
    class Car
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public Car(string Company,string Model)
        {
            this.Company = Company;
            this.Model = Model;
        }
    }
    class Garage
    {
        private Car _car;
        // Constructor injection
        public Garage(Car car)
        {
            _car = car;
        }
        //public Garage()
        //{
        //    _car = new Car(); // This line will cause a compile-time error because the Car constructor requires two parameters.
        //}
        public void ShowCarDetails()
        {
            Console.WriteLine($"Car Company: {_car.Company}, Model: {_car.Model}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage(new Car("Toyota", "Corolla"));
            garage.ShowCarDetails();
        }
    }
}
