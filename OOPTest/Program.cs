

using OOPTest;

Phone phone1 = new Phone();

phone1.Id = 1;
phone1.ProductName = "Iphone 14";

Phone phone2 = new Phone();

phone2.Id = 2;
phone2.ProductName = "Iphone 14";
phone2.CameraPixel = "45px";


Computer computer = new Computer();
computer.Id = 1;
computer.ProductName = "Hp";
computer.CpuSpeed = "345";

ProductManager productManager = new ProductManager();


productManager.Add(computer);
productManager.Add(phone1);
productManager.Add(phone2);


