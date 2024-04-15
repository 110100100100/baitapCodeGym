System.Console.Write("Nhập số tiền USD: ");
double USD = Convert.ToDouble(Console.ReadLine());
double exchangeRate = 23000;
double VND = USD * exchangeRate;

System.Console.WriteLine(USD + "USD tương đương với " + VND + " VND.");