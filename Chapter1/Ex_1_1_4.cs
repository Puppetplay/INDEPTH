using System.Collections.Generic;

namespace Chapter1_1_4
{
    public class Product
    {
        readonly string name;
        public string Name { get { return name; }}

        readonly decimal price;
        public decimal Price {  get { return price; } }
        

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product(name: "West Side Story", price: 9.99m),
                new Product(name: "Assassins", price: 14.99m),
                new Product(name: "Frogs", price: 13.99m),
                new Product(name: "Sweeney Todd", price: 10.99m),
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
