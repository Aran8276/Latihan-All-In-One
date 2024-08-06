namespace Hello;


// Statik tanpa parameter
class Latihan1
{
    static void Main(string[] args)
    {
        // Memanggil function / method yang kidda buat dibawah
        Ucapan();
    }

    static void Ucapan()
    {
        /* 
        Membuat Function / Method yang bernama "Ucapan" dengan parameter yang kosong. 
        Penggunaan dapat dipanggil dengan Ucapapan() 
        Karena deklarasi method menggunakan `static` maka dapat diakses tanpa membuat variable object class.
        */
        Console.WriteLine("Selamat Pagi");
    }
}

// Output Latihan 1: Selamat Pagi

// Non statik tanpa parameter
class Latihan2
{
    static void Main(string[] args)
    {
        // Memanggil method `Ucapan()`

        // Deklarasi object variable dulu (artinya dapat memanggil function-function yang adad di class `Latihan2`)
        Latihan2 objectLatihan = new Latihan2();

        /* 
        Terus kita bisa manggil method yang ada di class `Latihan2` dengan
        menggunakan variable object yang kita buat tadi. Disini panggil `Ucapan()`
        */
        objectLatihan.Ucapan();
    }
    /* 
    Private atau public static void Ucapan() tidak akan bisa karena dengan deklarasi method ini,
    harus menggunakan variable object
    */
    public void Ucapan()
    {
        Console.WriteLine("Aksata SMK6 Yes Yes Yes");
    }
}

// Output Latihan 2: Aksata SMK6 Yes Yes Yes

// Statik dengan parameter
class Latihan3
{
    static void Main(string[] args)
    {
        // Memanggil function `Ucapan` dengan argument "Selamat Pagi" yang tipe datanya string
        Ucapan("SMK Bisa SMK Hebat Hotel? Trivago");
    }

    // Deklarasi method `Ucapan` dengan parameter `kata` yang bertipe data string (https://i.sstatic.net/9lg1H.png)
    static void Ucapan(string kata)
    {
        Console.WriteLine(kata);
    }
}

// Output Latihan 3: SMK Bisa SMK Hebat Hotel? Trivago

// Statik dengan nilai balik & parameter
class Latihan4
{
    static void Main(string[] args)
    {
        /*
        Panggil method tersebut dengan argument "2008 Honda Accord".
        Karena di method tsb tidak ada Console.WriteLine dan diganti dengan return,
        maka kita harus membuatnya lagi disini
        */

        Console.WriteLine(UcapanDenganValue("2008 Honda Accord"));
    }
    // Deklarasi menggunakan `static string` artinya akan mengembalikan nilai string. Sebelumnya void yaitu tdk ada.
    static string UcapanDenganValue(string kata)
    {
        return kata;
    }
}

// Output Latihan 4: 2008 Honda Accord

// Non statik dengan nilai balik & parameter (CLASS INI TELAH DISETEL UNTUK StartupObject / Sebagai main entry point)
class Latihan5
{
    static void Main(string[] args)
    {
        Latihan5 objekLatihan = new Latihan5();
        Console.WriteLine(objekLatihan.Ucapan("Selamat Pagi!"));
    }

    public string Ucapan(string kata)
    {
        return kata;
    }
}

// Output Latihan 5: Selamat Pagi!