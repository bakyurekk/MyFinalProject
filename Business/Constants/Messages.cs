using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductCountOfCategoryError = "Bir Kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Category Limiti Aşıldı";
        public static string AuthorizationDenied = "Yetkiniz Yoktur";
        public static string UserAlreadyExists = "Kullanıcı Hatası";
        public static string AccessTokenCreated = "Token Oluşturuldu";
        public static string SuccessfulLogin = "Giriş Başarılı."
;        public static string PasswordError = "Şifre Hatalı";
        public static string UserNotFound = "Kullanıcı Bulunamadı.";
        public static string UserRegistered = "Kullanıcı Kaydedildi";
    }
}
