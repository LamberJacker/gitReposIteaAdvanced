using System;

namespace task1
{
    
    interface ICart
    {
        void AddProduct(Product product);
        void DeleteConcreteProduct(int k);
        void DeleteAllProduct();
        void ShowListProduct();
        void TotalPrice();
    }
    
    class Cart : ICart
    {
        Product[] productCart = new Product[5];

        public void AddProduct(Product product)
        {
            for (int i = 0; i < productCart.Length; i++)
            {
                if (productCart[i] == null)
                {
                    productCart[i] = product;
                    break;
                }
            }
        }
        public void DeleteConcreteProduct(int k)
        {
            productCart[k] = null;
        }
        public void DeleteAllProduct()
        {
           for (int i = 0; i < productCart.Length; i++)
           {
                productCart[i] = null;
           } 
        }
        public void ShowListProduct()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your cart have this product: ");
            for (int i = 0; i < productCart.Length; i++)
            {
                if (productCart[i] != null) Console.WriteLine("{0} - {1} $", productCart[i].name, productCart[i].price);
                else Console.WriteLine("Slot is empty");
            }
        }
        public void TotalPrice()
        {
            double counter = 0.0D;
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < productCart.Length; i++)
            {
                if (productCart[i] != null) counter += productCart[i].price;
            }
            Console.WriteLine("Total price = {0} $", counter);
        }
    }
    
    class Product
    {
        public string name;
        public double price;
        
        public void ShowInfoProduct()
        {
            Console.WriteLine("Name: {0} - Prise: {1} $", name, price);        
        }
    }
    class Banana : Product
    {
        public Banana()
        {
            base.name = "Bananas";
            base.price = 15.56;
        }
    }
    class Coconut : Product
    {
        public Coconut()
        {
            base.name = "Coconut";
            base.price = 25.65;
        }
    }
    class Apple : Product
    {
        public Apple()
        {
            base.name = "Apple";
            base.price = 8.33;
        }
    }
    class Orange : Product
    {
        public Orange()
        {
            base.name = "Orange";
            base.price = 12.35;
        }
    }
    class Apricot : Product
    {
        public Apricot()
        {
            base.name = "Apricot";
            base.price = 18.65;
        }
    }
    class Grape : Product
    {
        public Grape()
        {
            base.name = "Grape";
            base.price = 20.66;
        }
    }
    class Strawberries : Product
    {
        public Strawberries()
        {
            base.name = "Strawberries";
            base.price = 30.50;
        }
    }

    class Program
    {
        static void Main()
        {
            ICart cart = new Cart();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Goods of our magazine :");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Banana \n2. Apple \n3. Coconut\n4. Orange\n5. Apricot\n6. Grape \n7. Strawberries");
            bool check = false;
            bool check2 = false;
            bool check3 = false;
            bool check4 = false;
            string userInputFirst, userInputSecond, userInputThird;
            int j = 0;
            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Choose number of good who will be add to your cart :");
                    userInputFirst = Console.ReadLine();
                    switch (userInputFirst)
                    {
                        case "1":
                            Product ban = new Banana();
                            cart.AddProduct(ban);
                            check3 = false;
                            break;
                        case "2":
                            Product app = new Apple();
                            cart.AddProduct(app);
                            check3 = false;
                            break;
                        case "3":
                            Product coc = new Coconut();
                            cart.AddProduct(coc);
                            check3 = false;
                            break;
                        case "4":
                            Product orange = new Orange();
                            cart.AddProduct(orange);
                            check3 = false;
                            break;
                        case "5":
                            Product apric = new Apricot();
                            cart.AddProduct(apric);
                            check3 = false;
                            break;
                        case "6":
                            Product grape = new Grape();
                            cart.AddProduct(grape);
                            check3 = false;
                            break;
                        case "7":
                            Product straw = new Strawberries();
                            cart.AddProduct(straw);
                            break;
                        default: check3 = true; Console.WriteLine("Wrong input, repeat please"); break;
                    }
                } while (check3 == true);
                
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Write command:\n\"S\" - for stop your buy\n\"N\"- for delete some good\n\"D\"- for buy any good\n\"DALL\"- for delete all from cart");
                Console.WriteLine("\"SW\" - for show list your goods");
                do
                {
                    userInputSecond = Console.ReadLine();
                    switch (userInputSecond)
                    {
                    case "N":
                            j++;
                            if (j == 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Your cart is full u must buy your goods and start new buy or Delete some goods from your card!");
                                check2 = false;
                                break;
                            }
                            else
                            {
                                check2 = true;
                                break;
                            }
                    case "S":
                        if (j == 5) check2 = false;
                        else check = check2 = true;
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("What position u want to delete from your cart");
                            do
                            {
                                userInputThird = Console.ReadLine();
                                switch (userInputThird)
                                {
                                    case "1": cart.DeleteConcreteProduct(0); check4 = true; break;
                                    case "2": cart.DeleteConcreteProduct(1); check4 = true; break;
                                    case "3": cart.DeleteConcreteProduct(2); check4 = true; break;
                                    case "4": cart.DeleteConcreteProduct(3); check4 = true; break;
                                    case "5": cart.DeleteConcreteProduct(4); check4 = true; break;
                                    default: Console.WriteLine("Wrong input, repeat please"); check4 = false; break;
                                }
                            } while (check4 == false);
                        check2 = false;
                        break;
                    case "DALL":
                        cart.DeleteAllProduct();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Write your next command:");
                        break;
                    case "SW":
                        check2 = false;
                        cart.ShowListProduct();
                        Console.WriteLine(new string('-', 35));
                        cart.TotalPrice();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Write your next command:");
                        break;
                    default: check2 = false;  Console.WriteLine("Wrong input, repeat please"); break;
                    }
                } while (check2 == false);

            } while (check == false);
            cart.ShowListProduct();
            Console.WriteLine(new string('-', 35));
            cart.TotalPrice();
            Console.ReadKey();
        }
    }
}
