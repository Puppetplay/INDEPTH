using System.Collections.Generic;

namespace Chapter1_1_2
{
    public class Product
    {
        string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        decimal price;
        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("West Side Story", 9.99m));
            list.Add(new Product("Assassins", 14.99m));
            list.Add(new Product("Frogs", 13.99m));
            list.Add(new Product("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", name, price);
        }
    }




    //  1.1.2 C#2.0에서 보다 강화된 리스트 타입
    //
    // 1. ArrayList에 넣은 데이터에 대한 컴파일 정보가 없다. GetSampleProducts 함수를 만들어
    //   리스트에 값을 추가 하고 있지만 컴파일러는 어떤 값이 추가되는지 알 수 없다.
    //
    //   -> 컴파일러가 List안에 반드시 Product타입이 할당될 수 있다는 것을 안다.
    //      다른 타입을 넣으려고 시도하면 컴파일러는 에러를 반환한다.
    //      결과를 타입변환해 주지 않아도 사용가능하다.

}
