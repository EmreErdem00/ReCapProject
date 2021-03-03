using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
   {
       public static string CarAdded = "Araç eklendi";
       public static string CarDeleted = "Araç silindi";
       public static string CarNameInvalid = "Araç ismi geçersiz";
       public static string CarsListed = "Araçlar listelendi";
       public static string MaintenanceTime = "Bakım zamanı";
       public static string CarUpdated = "Araç güncellendi";
       public static string UserAdded = "Kullanıcı eklendi";
        public static string UserShowed = "Kullanıcı gösterildi";

        public static string UserDeleted = "Kullanıcı silindi";
       public static string UserUpdated = "Kullanıcı güncellendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersShowed = "Müşteriler gösterildi";

        public static string RentAdded = "Rent eklendi";
        public static string RentDeleted = "Rent silindi";
        public static string RentUpdated = "Rent güncellendi";
        public static string RentsShowed = "Rent gösterildi";

        public static string NoMoreImage = "5 adetten fazla araç resmi yüklenemez";
        public static string ImagesAdded ="Resim başarıyla eklendi";
        public static string CarImageAdded ="Araç resmi eklendi";
        public static string CarImageDeleted="Araç resmi silindi";
        public static string CarImageUpdated="Araç resmi güncellendi";
        public static string GetCarImageById ="Araç id sine göre resimler listelendi ";
        public static string GetById ="Resim idsine göre getirildi";
        public static string AuthorizationDenied ="Rollendirme izni verilmedi";
    }
}

