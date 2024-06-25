
using Exam;

Customer customer1 = new Customer();
Cashier cashier1 = new Cashier();
Director director1 = new Director();

customer1.Id = 1;
customer1.FullName = "Elmir";
customer1.Balance = 678.89m;

cashier1.Id = 1;
cashier1.FullName = "Kamil";
cashier1.CashierCode = 3456;

director1.Id = 1;
director1.FullName = "Kenan ";
director1.PhoneNumber = "+99455677777";
director1.Majorty = "IT";



IPersonManager<Cashier> cashierManager = new CashierManager();
cashierManager.Add(cashier1);

IPersonManager<Customer> customerManager = new CustomerManager();
customerManager.Add(customer1);

IPersonManager<Director> directorManager = new DirectorManager();
directorManager.Add(director1);

//SOLID => 
