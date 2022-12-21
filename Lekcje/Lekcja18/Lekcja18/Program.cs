using Lekcja18;

ComputerBuilder builder = new ComputerBuilder();
Computer pc = builder
    .WithProcessor("Intel i7")
    .WithGraphicsCard("Invidia Geforce 3090")
    .WithRAM(16)
    .WithStorage(1024)
    .Build();


builder.Reset();

Computer pc2 = builder
    .WithProcessor("AMD Ryzen 7600G")
    .WithRAM(16)
    .WithStorage(512)
    .Build();

