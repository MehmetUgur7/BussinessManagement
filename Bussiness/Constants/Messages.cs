using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string PersonAdded = "Kişi eklendi.";
        public static string PersonUpdated = "Kişi güncellendi.";
        public static string PersonNameInvalid = "Kişi ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string PersonsListed = "Kişiler Listelendi";
        public static string PersonNameAlreadyExists = "Aynı isimde başka bir kişi var.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
