using System;
namespace OOP 
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars(model: "Bugatti Chiron", year: 2024, price: 3900000, speed: 420);
            //Car klassining ob'ektini yaratib uningga ma'lumotlar berilsin. 
            car.Model = "BMW M5 CS";
            car.Year = 2022;
            car.Price = 142000;  //<=Getter va setterlarni foydalanib ob'ektning xususiyatlarini o'zgartiring.
            car.Speed = 304;
            Console.WriteLine(car.GetCarInfo());    //GetCarInfo() metodini chaqiring va mashina haqida ma'lumotlarni ko'rsating. 
            car.CalculateDepreciation(1);           //CalculateDepreciation() metodini bir nechta yil qiymatlari bilan chaqiring va mashinaning yangilangan narxini ko'rsating.
            car.CalculateDepreciation(2); 
            car.CalculateDepreciation(3); 
            car.CalculateDepreciation(4); 
        
        }
    }
}



/*
OOP bo’limi uchun 2-amaliy vazifa
Car klassini quyidagi xususiyatlar va maxfiy maydonlar bilan yarating: 

1.Model (string): Mashinaning modeli. 
2.Year (int): Mashinaning ishlab chiqarilgan yili. 
3.Price (decimal): Mashinaning narxi. 
4.Speed (decimal): Mashinaning tezligi.

Car klassida quyidagi funktsiyalar amalga oshiriladi: 

Ob'ektni boshlang'ich qiymatlarini (marka, model, yil, narx) o'rnatish uchun parametrlarni qabul qiladigan constructor. 
Barcha xususiyatlarga kirishni ruxsat beradigan getter va setterlar (xususiyatlar). 
GetCarInfo() deb nomlangan metod, mashina haqida barcha ma'lumotlarni (marka, model, yil, narx) qaytaradigan string. 
CalculateDepreciation(int years) deb nomlangan metod, mashina qiymatining yaratilgan yildan boshlab yillar o'tganda qancha kamayishini hisoblaydigan funktsiya. Yillik 10%lik kamayish qiymatini o'limoq.
 
Shuningdek, qo’shimcha shu ishlar bajarilishi kerak: 

Car klassining ob'ektini yaratib uningga ma'lumotlar berilsin. 
Getter va setterlarni foydalanib ob'ektning xususiyatlarini o'zgartiring. 
GetCarInfo() metodini chaqiring va mashina haqida ma'lumotlarni ko'rsating. CalculateDepreciation() metodini bir nechta yil qiymatlari bilan chaqiring va mashinaning yangilangan narxini ko'rsating.
*/