using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Ürün sayısı 10 u geçti";
        public static string ProductNameAlreadyExists="Aynı isimde ürün var";
        public static string CategoryLimitExceded="Kategori limiti aşıldıgı için yeni ürün eklenemiyor";
    }
}
