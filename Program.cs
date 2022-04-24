using System;
namespace array
{    class Program
    { static void Main(string[] args)
        { while(true){
            System.Console.WriteLine("###Patika.Dev Kumar makinesi### \n Oyunun kuralı; makineye soktuğunuz ücretin 10 katını kazanacaksınız. \n Tek şart; 3 adet rakamdan en az birini bilmek. \nİYİ ŞANSLAR!");
                 string[] hediye = new string[5] {"Mini Copper","Bir Torba Kömür","Bir paket makarna","Elektriği olmayan köye buzdolabı","Kafaya fırlatılan keyif çayı"};
                 Array.Sort(hediye);
                 for(int i=1;i<=5;i++){System.Console.WriteLine("Hediye"+ i + ":" + " " + hediye[i-1]);}
                 System.Console.WriteLine("Lütfen ödemek istediğiniz ücreti giriniz (TL):");
                 Int32 ucret =Int32.Parse(Console.ReadLine());
                 System.Console.WriteLine("3 adet rakam giriniz:");
                Int32 sayi1 =Int32.Parse(Console.ReadLine());
                Random sans1 = new Random();
                int sayi11 = sans1.Next(0,9);
                Random hediye1 = new Random();
                int sayi111 = hediye1.Next(0,4);
                Int32 sayi2 =Int32.Parse(Console.ReadLine());
                 Random sans2 = new Random();
                int sayi22 = sans1.Next(0,9);
                Int32 sayi3 =Int32.Parse(Console.ReadLine());
                 Random sans3 = new Random();
                int sayi33 = sans1.Next(0,9);
                if(sayi11 == sayi1 || sayi22 == sayi1 || sayi33 == sayi1){
                    Console.WriteLine("BİNGO!" + ucret*10 + "TL Kazandınız! Ayrıca hediye kazandınız:" + hediye[sayi111]);Console.WriteLine("");}
                    else if(sayi11 == sayi2 || sayi22 == sayi2 || sayi33 == sayi2){
                    Console.WriteLine("BİNGO!" + ucret*10 + "TL Kazandınız! Ayrıca hediye kazandınız:" + hediye[sayi111]);Console.WriteLine("");}
                    else if(sayi11 == sayi3 || sayi22 == sayi3 || sayi33 == sayi3){
                    Console.WriteLine("BİNGO!" + ucret*10 + "TL Kazandınız! Ayrıca hediye kazandınız:" + hediye[sayi111]);Console.WriteLine("");}
               else {System.Console.WriteLine(" Kumarda kaybeden aşkta kazanır :) Tekrar oynayın.");}
        }


     } }
        
        
        }
    

