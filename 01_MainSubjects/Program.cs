using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            Console.Write("Merhaba Dünya");
            Console.WriteLine("Selam!");

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler
            //string
            //degisken_turu degisken_adi

            //string name;
            //name = "Emir";
            //Console.WriteLine(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Emirhan";
            customerSurname = "Özmen";
            customerPhone = "+90 450 41 90";
            customerEmail = "emirhannozmen@gmail.com";
            district = "Ataşehir";
            city = "İstanbul";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-------------------------------");

            Console.WriteLine();
            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "+90 400 300 80 70";
            customerEmail = "aysegul@gmail.com";
            district = "Sapanca";
            city = "Sakarya";

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-------------------------------");

            #endregion

            #region İnt Değişkenler
            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("----Patates Kızartması: " + friesPrice + " TL");
            Console.WriteLine("----Kola: " + cokePrice + " TL");
            Console.WriteLine("----Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("----Su: " + waterPrice + " TL");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;



            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Paztates Kızartması Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine();

            int totalPrice = totalLemonadePrice + totalFriesPrice + totalHamburgerPrice + totalPizzaPrice + totalWaterPrice +
               +totalCokePrice;
            Console.WriteLine("TOPLAM ÖDENECEK HESAP: " + totalPrice + " TL");
            #endregion


            Console.Read();
        }
    }
}
