using System.Collections.Generic;

namespace Chapter1_1_3
{
    public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        Product() { }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product { Name = "West Side Story", Price = 9.99m },
                new Product { Name = "Assassins", Price = 14.99m },
                new Product { Name = "Frogs", Price = 13.99m },
                new Product { Name = "Sweeney Todd", Price = 10.99m },
            };
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", Name, Price);
        }
    }




    // 1.1.3 자동으로 구현되는 프로퍼티(C# 3.0)
    //
    // 2. 코드에서 public 타입의 getter 속성을 프로퍼티에 정의했다.
    //   이 이야기는 만약 private setter를 제공하고 싶을 때, setter 또한 정의해 주어야한다.
    //
    // 3. 프로퍼티와 변수들을 만들기 위해서 string과 decimal과 같은 번거롭고 복잡한 많은 코드들을 작성해야한다.
}
