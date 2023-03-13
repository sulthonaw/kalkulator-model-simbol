namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int angka1 = 0, angka2 = 0;
                Console.Write("\n*Angka\nAngka 1 : ");
                angka1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n*Angka\nAngka 2 : ");
                angka2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n*(+, -, *, :)\nOperasi : ");
                char pilihMenu = Convert.ToChar(Console.ReadLine());

                switch (pilihMenu)
                {
                    case '+':
                        Console.WriteLine("\nHasil = " + Tambah(angka1, angka2));
                        break;
                    case '-':
                        Console.WriteLine("\nHasil = " + Kurang(angka1, angka2));
                        break;
                    case '*':
                        Console.WriteLine("\nHasil = " + Kali(angka1, angka2));
                        break;
                    case ':':
                        Console.WriteLine("\nHasil = " + Bagi(angka1, angka2));
                        break;
                    default:
                        Console.WriteLine("\nPilihan anda tidak tersedia");
                        break;
                }

                Console.Write("\napakah anda ingin melanjutkan? (y/n)");
                string selesai;
                while (true)
                {
                    selesai = Console.ReadLine();
                    if (selesai == "y" || selesai == "n") break;
                    else Console.WriteLine("Pilihan tidak tersedia");
                }
                if (selesai == "n") break;
            }
        }

        // function pertambahan
        static int Tambah(int angka1, int angka2)
        {
            int hasil = angka1 + angka2;
            return hasil;
        }

        // function pengurangan
        static int Kurang(int angka1, int angka2)
        {
            int hasil = angka1 - angka2;
            return hasil;
        }

        // function perkalian
        static int Kali(int angka1, int angka2)
        {
            int hasil = angka1 * angka2;
            return hasil;
        }

        // function pembagian
        static int Bagi(int angka1, int angka2)
        {
            int hasil = angka1 / angka2;
            return hasil;
        }
    }
}