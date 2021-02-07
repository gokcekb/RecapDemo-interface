using System;
using System.Collections.Generic;
using System.Text;

namespace AlıştırmaClasses
{
    class Customer
    {
        //public string FirstName; böyle de yazabiliriz ama get ederken ekstra durum varsa yapamayız.
        //Property
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

// Müşterinin özelliklerini tutmak için de classlardan yararlanıyoruz.
