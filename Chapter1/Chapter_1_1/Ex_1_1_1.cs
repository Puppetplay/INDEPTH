using System.Collections;

namespace Chapter1_1_1
{
    public class Product
    {
        string name;
        public string Name { get { return name; } }

        decimal price;
        public decimal Price { get { return price; } }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
        
        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
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




    // 3가지 한계 -  1.1.1 C#1.0에서의 'Product' 타입
    //
    // 1. ArrayList에 넣은 데이터에 대한 컴파일 정보가 없다. GetSampleProducts 함수를 만들어
    //   리스트에 값을 추가 하고 있지만 컴파일러는 어떤 값이 추가되는지 알 수 없다.
    //
    // 2. 코드에서 public 타입의 getter 속성을 프로퍼티에 정의했다.
    //   이 이야기는 만약 private setter를 제공하고 싶을 때, setter 또한 정의해 주어야한다.
    //
    // 3. 프로퍼티와 변수들을 만들기 위해서 string과 decimal과 같은 번거롭고 복잡한 많은 코드들을 작성해야한다.

}
