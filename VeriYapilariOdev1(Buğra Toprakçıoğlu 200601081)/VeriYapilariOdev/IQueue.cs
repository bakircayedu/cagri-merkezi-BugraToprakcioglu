using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace VeriYapilariOdev
{
    public interface IQueue

    {
        void Insert(Cagri item); //Kuyruğa Çağrı ekler
        Cagri Remove(); //Kuyruktan Çağrıyı kaldırır (First in first out)
        Cagri Peek(); //Kuyruğun en önündeki Çağrıyı döndürür

        Boolean IsEmpty(); //Kuyruk boş mu kontrol etmektedir

        int Count(); //Kuyruğun eleman sayısını döndürür

        Cagri Access(int position); //Kuyruğun belirtelen pozisyonundaki Çağrıyı döndürür

    }
}
