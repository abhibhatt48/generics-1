using System;
namespace src{
    class Product{
        public string name ;
        public string type ;
        public int quantity;
        public double price ;

        public Product(){
            
        }
        public Product(string name,double price ,int quantity ,string type){
            this.name = name;
            this.type = type;
            this.quantity = quantity;
            this.price = price;
        }

    }
}