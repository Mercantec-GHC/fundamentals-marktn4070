//int saleAmount = 1001;
//int discount;

//if (saleAmount > 1000)
//{
//    discount = 100;
//}
//else
//{
//    discount = 50;
//}

//Console.WriteLine($"Discount: {discount}");

//< evaluate this condition > ? <if condition is true, return this value > : <if condition is false, return this value >
// ==============

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");