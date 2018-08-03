using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float sizeSleeve = float.Parse(Console.ReadLine());
            float sizeFront = float.Parse(Console.ReadLine());
            string typeShirt = Console.ReadLine();
            string bowTie = Console.ReadLine();
            float priceShirt;

            float sizeFull = sizeFront * 2f + sizeSleeve * 2f;
            sizeFull = sizeFull + sizeFull * 0.1f;
            sizeFull = sizeFull / 100;
                
            if(typeShirt == "Cotton")
            {
                priceShirt = sizeFull * 12 + 10;
                if(bowTie == "Yes")
                {
                    priceShirt = priceShirt + priceShirt * 0.2f;
                    Console.WriteLine("The price of the shirt is: {0:F2}lv. ",priceShirt);
                }
                else
                {
                    Console.WriteLine("The price of the shirt is: {0:F2}lv. ", priceShirt);
                }
            }

            if (typeShirt == "Linen")
            {
                priceShirt = sizeFull * 15 + 10;
                if (bowTie == "Yes")
                {
                    priceShirt = priceShirt + priceShirt * 0.2f;
                    Console.WriteLine("The price of the shirt is: {0:F2}lv. ", priceShirt);
                }
                else
                {
                    Console.WriteLine("The price of the shirt is: {0:F2}lv. ", priceShirt);
                }
            }

            if (typeShirt == "Denim")
            {
                priceShirt = sizeFull * 20 + 10;
                if (bowTie == "Yes")
                {
                    priceShirt = priceShirt + priceShirt * 0.2f;
                    Console.WriteLine("The price of the shirt is: {0:F2}lv. ", priceShirt);
                }
                else
                {
                    Console.WriteLine("The price of the shirt is: {0:F2}lv. ", priceShirt);
                }
            }


            if (typeShirt == "Twill")
            {
                priceShirt = sizeFull * 16 + 10;
                if (bowTie == "Yes")
                {
                    priceShirt = priceShirt + priceShirt * 0.2f;
                    Console.WriteLine("The price of the shirt is: {0:F2}lv. ", priceShirt);
                }
                else
                {
                    Console.WriteLine("The price of the shirt is: {0:F2}lv. ", priceShirt);
                }
            }


            if (typeShirt == "Flannel")
            {
                priceShirt = sizeFull *11 + 10;
                if (bowTie == "Yes")
                {
                    priceShirt = priceShirt + priceShirt * 0.2f;
                    Console.WriteLine("The price of the shirt is: {0:F2}lv. ", priceShirt);
                }
                else
                {
                    Console.WriteLine("The price of the shirt is: {0:F2}lv. ", priceShirt);
                }
            }



        }
    }
}
