Console.WriteLine("Selamat Datang");
Console.Write("Masukkan nama : ");
string namaLengkap = Console.ReadLine();
Console.WriteLine("Nama kamu adalah " + namaLengkap);
Console.WriteLine($"Nama kamu adalah {namaLengkap}");

Console.Write("Masukkan umur : ");
string inputUmur = Console.ReadLine();

Console.WriteLine("Umur kamu 5 tahun lagi : " + (inputUmur + 5) );

int umur = Convert.ToInt32(inputUmur);
Console.WriteLine("Umur kamu 5 tahun lagi : " + (umur + 5) );

Console.WriteLine("Nama kamu " + namaLengkap + " dan umurmu " + umur);
Console.WriteLine($"Nama kamu {namaLengkap} dan umurmu {umur}");