using System;
using System.Collections;
using System.Collections.Generic;

namespace GAzi.Sube2.CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //ArrayList al = new ArrayList();
            //al.Add("2");
            //al.Add("5");
            //al.Add("Ahmet");
            //al.Add("Ahmet");
            //al.Add("Ahmet");
            //al.Add("5");
            //al.Add("Ahmet");
            //al.Add("Ahmet");
            //al.Add("Ahmet");
            //al.Capacity = al.Count; //kapasitesi girilen elemanla aynı oldu 


            //Console.WriteLine(al.Count);
            //Console.WriteLine(al.Capacity);

            //int sayi = (int)al[1];

            //Hashtable ht = new Hashtable(); //keyler tekil* index numarası yerine key ile erişilir burda key plaka value il 
            //ht.Add(6, "Ankara");
            //ht.Add(34, "İstanbul");
            //ht.Add(44, "Malatya");
            //ht.Add(35, "İzmir");

            //foreach (DictionaryEntry item in ht) //iki objekti struct olarak tutuyor struct classların küçük versiyonu stackte bulunur
            //{
            //    Console.WriteLine(item.Value);
            //}


            //değer tipinin objekte dönmesi boxing objekti değer tipine dönüştürme unboxing denir. performans problemi oluşturur

            //for (int i = 0; i < al.Count; i++)
            //{
            //    Console.WriteLine(al[i]);
            //}
            //foreach (object item in al)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue q = new Queue(); //kuyruk işlemi yürütülüyor ilk gelen ilk çıkar
            //q.Enqueue("Mümin");
            //q.Enqueue("Furkan");
            //q.Enqueue("Uğur");

            //Console.WriteLine(q.Peek());  //peek = bakmak  hangi eleman en önde
            //q.Dequeue(); //kalan eleman

            //foreach (object item in q)
            //{
            //    Console.WriteLine(item);
            //}
            //OBJEKTLERDE TİP GÜVENLİĞİ YOK 
            //Stack s = new Stack(); //son gelen ilk çıkar
            //s.Push("Tabak1");
            //s.Push("Tabak2");
            //s.Push("Tabak3");

            //s.Pop();

            //foreach (object item in s)
            //{
            //    Console.WriteLine(item);
            //}
            //NON GENERİC TİP GÜVENLİĞİ OLMAYAN

            //GENERİC COLLECTİONS - yapılar t yerine ne dersek o oluyor verilecek tipler sınırlanıyor

            //Deneme<int,string> d = new Deneme<int,string>();
            //d.sayi1 = 5;
            //d.sayi2 = 6;

            List<int> lst = new List<int>();
            lst.Add(5);
            lst.Add(10);
            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class Deneme<T,M> where T : struct where M:struct //generic constarint - Kısıtlayıcı
    {
        public T sayi1;
        public M sayi2;
    }
}
